//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Cliver.InvoiceParser
{
    /*
 TBD:
 - add columns: modified, used time, comment
 - add edit2:comment,to detect template use ?-? pages, this template cannot share a file with another template
 - ? Template not enherited but embedded
 - custom Value in anchors and marks table

 - MainForm to WPF;
- ? store each template in separate file;

- switch to Tesseract.4

     */
    class Program
    {
        static Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += delegate (object sender, UnhandledExceptionEventArgs args)
            {
                Exception e = (Exception)args.ExceptionObject;
                LogMessage.Error(e);
                Environment.Exit(0);
            };

            Message.TopMost = true;

            Config.Reload();
            LogMessage.DisableStumblingDialogs = false;
            Log.ShowDeleteOldLogsDialog = false;
            Log.Initialize(Log.Mode.ONLY_LOG, Log.CompanyCommonDataDir, true);
        }

        [STAThread]
        static void Main()
        {
            try
            {
                PdfDocumentParser.Program.Initialize();

                //PdfDocumentParser.TemplateWindow tw = new PdfDocumentParser.TemplateWindow();
                //tw.ShowDialog();
                
                Application.Run(MainForm.This);
            }
            catch (Exception e)
            {
                Message.Error(e);
            }
            Environment.Exit(0);
        }
    }
}