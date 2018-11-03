﻿namespace Cliver.PdfDocumentParser
{
    partial class AnchorOcrTextControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.OcrEntirePage = new System.Windows.Forms.CheckBox();
            this.text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionDeviationIsAbsolute = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cSearchRectangleMargin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchRectangleMargin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionDeviation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRectangleMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDeviation)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Ocr Entire Page:";
            // 
            // OcrEntirePage
            // 
            this.OcrEntirePage.AutoSize = true;
            this.OcrEntirePage.Location = new System.Drawing.Point(167, 49);
            this.OcrEntirePage.Name = "OcrEntirePage";
            this.OcrEntirePage.Size = new System.Drawing.Size(15, 14);
            this.OcrEntirePage.TabIndex = 84;
            this.OcrEntirePage.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(6, 85);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(207, 36);
            this.text.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Pattern:";
            // 
            // PositionDeviationIsAbsolute
            // 
            this.PositionDeviationIsAbsolute.AutoSize = true;
            this.PositionDeviationIsAbsolute.Location = new System.Drawing.Point(144, 5);
            this.PositionDeviationIsAbsolute.Name = "PositionDeviationIsAbsolute";
            this.PositionDeviationIsAbsolute.Size = new System.Drawing.Size(15, 14);
            this.PositionDeviationIsAbsolute.TabIndex = 91;
            this.PositionDeviationIsAbsolute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = ")";
            // 
            // cSearchRectangleMargin
            // 
            this.cSearchRectangleMargin.AutoSize = true;
            this.cSearchRectangleMargin.Location = new System.Drawing.Point(144, 27);
            this.cSearchRectangleMargin.Name = "cSearchRectangleMargin";
            this.cSearchRectangleMargin.Size = new System.Drawing.Size(15, 14);
            this.cSearchRectangleMargin.TabIndex = 97;
            this.cSearchRectangleMargin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Search Rectangle Margin:";
            // 
            // SearchRectangleMargin
            // 
            this.SearchRectangleMargin.Location = new System.Drawing.Point(166, 25);
            this.SearchRectangleMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SearchRectangleMargin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SearchRectangleMargin.Name = "SearchRectangleMargin";
            this.SearchRectangleMargin.Size = new System.Drawing.Size(47, 20);
            this.SearchRectangleMargin.TabIndex = 96;
            this.SearchRectangleMargin.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "(absolute:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Position Deviation:";
            // 
            // PositionDeviation
            // 
            this.PositionDeviation.DecimalPlaces = 1;
            this.PositionDeviation.Location = new System.Drawing.Point(166, 3);
            this.PositionDeviation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PositionDeviation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PositionDeviation.Name = "PositionDeviation";
            this.PositionDeviation.Size = new System.Drawing.Size(47, 20);
            this.PositionDeviation.TabIndex = 93;
            this.PositionDeviation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AnchorOcrTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.PositionDeviationIsAbsolute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cSearchRectangleMargin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchRectangleMargin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PositionDeviation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OcrEntirePage);
            this.Name = "AnchorOcrTextControl";
            this.Size = new System.Drawing.Size(216, 124);
            ((System.ComponentModel.ISupportInitialize)(this.SearchRectangleMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionDeviation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox OcrEntirePage;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox PositionDeviationIsAbsolute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cSearchRectangleMargin;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown SearchRectangleMargin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown PositionDeviation;
    }
}
