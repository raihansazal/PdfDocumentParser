//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Cliver.PdfDocumentParser
{
    /// <summary>
    /// pdf page parsing API
    /// </summary>
    public partial class Page
    {
        public object GetValue(string fieldName)
        {
            object o = false;
            foreach (Template.Field f in pageCollection.ActiveTemplate.Fields.Where(x => x.Name == fieldName))
            {
                o = getValue(f);
                if (o != null)
                    return o;
            }
            if (o == null)
                return null;
            throw new Exception("These is no field[name=" + fieldName + "]");
        }

        object getValue(Template.Field field)
        {
            if (!field.IsSet())
                throw new Exception("Field is not set.");
            if (field.Rectangle.Width <= Settings.Constants.CoordinateDeviationMargin || field.Rectangle.Height <= Settings.Constants.CoordinateDeviationMargin)
                throw new Exception("Rectangle is malformed.");
            RectangleF r = field.Rectangle.GetSystemRectangleF();
            RectangleF r0 = r;
            if (field.LeftAnchor != null)
            {
                Page.AnchorActualInfo aai = GetAnchorActualInfo(field.LeftAnchor.Id);
                if (!aai.Found)
                    return null;
                r.X += aai.Shift.Width - field.LeftAnchor.Shift;
            }
            if (field.TopAnchor != null)
            {
                Page.AnchorActualInfo aai = GetAnchorActualInfo(field.TopAnchor.Id);
                if (!aai.Found)
                    return null;
                r.Y += aai.Shift.Height - field.TopAnchor.Shift;
            }
            if (field.RightAnchor != null)
            {
                Page.AnchorActualInfo aai = GetAnchorActualInfo(field.RightAnchor.Id);
                if (!aai.Found)
                    return null;
                r.Width += r0.X - r.X + aai.Shift.Width - field.RightAnchor.Shift;
                if (r.Width <= 0)
                    return null;
            }
            if (field.BottomAnchor != null)
            {
                Page.AnchorActualInfo aai = GetAnchorActualInfo(field.BottomAnchor.Id);
                if (!aai.Found)
                    return null;
                r.Height += r0.Y - r.Y + aai.Shift.Height - field.BottomAnchor.Shift;
                if (r.Height <= 0)
                    return null;
            }
            switch (field.Type)
            {
                case Template.Field.Types.PdfText:
                    Template.Field.PdfText pt = (Template.Field.PdfText)field;
                    if (pt.ValueAsCharBoxes)
                        return Pdf.GetCharBoxsSurroundedByRectangle(PdfCharBoxs, r);
                    return Pdf.GetTextSurroundedByRectangle(PdfCharBoxs, r, pageCollection.ActiveTemplate.TextAutoInsertSpaceThreshold, pageCollection.ActiveTemplate.TextAutoInsertSpaceSubstitute);
                case Template.Field.Types.OcrText:
                    Template.Field.OcrText ot = (Template.Field.OcrText)field;
                    if (ot.ValueAsCharBoxes)
                        return Ocr.GetCharBoxsSurroundedByRectangle(ActiveTemplateOcrCharBoxs, r);
                    return Ocr.This.GetText(ActiveTemplateBitmap, r);
                case Template.Field.Types.ImageData:
                    using (Bitmap rb = GetRectangleFromActiveTemplateBitmap(r.X / Settings.Constants.Image2PdfResolutionRatio, r.Y / Settings.Constants.Image2PdfResolutionRatio, r.Width / Settings.Constants.Image2PdfResolutionRatio, r.Height / Settings.Constants.Image2PdfResolutionRatio))
                    {
                        return ImageData.GetScaled(rb, Settings.Constants.Image2PdfResolutionRatio);
                    }
                default:
                    throw new Exception("Unknown option: " + field.Type);
            }
        }    

        /// <summary>
        /// Auxiliary method which can be applied to a string during post-processing
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string NormalizeText(string value)
        {
            if (value == null)
                return null;
            value = FieldPreparation.ReplaceNonPrintableChars(value);
            value = Regex.Replace(value, @"\s+", " ");
            value = value.Trim();
            return value;
        }
    }
}