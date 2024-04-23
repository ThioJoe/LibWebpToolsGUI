using System;

namespace dWebpGUI
{
    partial class dWebpGUI
    {
        private System.ComponentModel.IContainer components = null;

        // Declaration of form controls
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCommandPreview;
        private System.Windows.Forms.TextBox txtCommandPreview;
        private System.Windows.Forms.CheckBox chkMultiThreading;
        private System.Windows.Forms.Label lblResize;
        private System.Windows.Forms.TextBox txtResizeWidth;
        private System.Windows.Forms.TextBox txtResizeHeight;
        private System.Windows.Forms.RadioButton rbBMP;
        private System.Windows.Forms.RadioButton rbTIFF;
        private System.Windows.Forms.RadioButton rbPAM;
        private System.Windows.Forms.RadioButton rbPPM;
        private System.Windows.Forms.RadioButton rbPGM;
        private System.Windows.Forms.RadioButton rbYUV;
        private System.Windows.Forms.GroupBox grpOutputFormat;
        private System.Windows.Forms.RadioButton rbPNG;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInputFile = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCommandPreview = new System.Windows.Forms.Label();
            this.txtCommandPreview = new System.Windows.Forms.TextBox();
            this.chkMultiThreading = new System.Windows.Forms.CheckBox();
            this.lblResize = new System.Windows.Forms.Label();
            this.txtResizeWidth = new System.Windows.Forms.TextBox();
            this.txtResizeHeight = new System.Windows.Forms.TextBox();
            this.rbBMP = new System.Windows.Forms.RadioButton();
            this.rbTIFF = new System.Windows.Forms.RadioButton();
            this.rbPAM = new System.Windows.Forms.RadioButton();
            this.rbPPM = new System.Windows.Forms.RadioButton();
            this.rbPGM = new System.Windows.Forms.RadioButton();
            this.rbYUV = new System.Windows.Forms.RadioButton();
            this.grpOutputFormat = new System.Windows.Forms.GroupBox();
            this.rbPNG = new System.Windows.Forms.RadioButton();
            this.grpOutputFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(18, 15);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(53, 13);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input File:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(150, 12);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(252, 20);
            this.txtInputFile.TabIndex = 1;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(18, 45);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(61, 13);
            this.lblOutputFile.TabIndex = 2;
            this.lblOutputFile.Text = "Output File:";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(150, 42);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(252, 20);
            this.txtOutputFile.TabIndex = 3;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(22, 350);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 30);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCommandPreview
            // 
            this.lblCommandPreview.AutoSize = true;
            this.lblCommandPreview.Location = new System.Drawing.Point(18, 390);
            this.lblCommandPreview.Name = "lblCommandPreview";
            this.lblCommandPreview.Size = new System.Drawing.Size(98, 13);
            this.lblCommandPreview.TabIndex = 11;
            this.lblCommandPreview.Text = "Command Preview:";
            // 
            // txtCommandPreview
            // 
            this.txtCommandPreview.Location = new System.Drawing.Point(22, 410);
            this.txtCommandPreview.Multiline = true;
            this.txtCommandPreview.Name = "txtCommandPreview";
            this.txtCommandPreview.ReadOnly = true;
            this.txtCommandPreview.Size = new System.Drawing.Size(380, 100);
            this.txtCommandPreview.TabIndex = 12;
            // 
            // chkMultiThreading
            // 
            this.chkMultiThreading.AutoSize = true;
            this.chkMultiThreading.Location = new System.Drawing.Point(22, 70);
            this.chkMultiThreading.Name = "chkMultiThreading";
            this.chkMultiThreading.Size = new System.Drawing.Size(106, 21);
            this.chkMultiThreading.TabIndex = 4;
            this.chkMultiThreading.Text = "Multi-Threading";
            this.chkMultiThreading.UseVisualStyleBackColor = true;
            this.chkMultiThreading.CheckedChanged += new System.EventHandler(this.chkMultiThreading_CheckedChanged);
            // 
            // lblResize
            // 
            this.lblResize.AutoSize = true;
            this.lblResize.Location = new System.Drawing.Point(18, 100);
            this.lblResize.Name = "lblResize";
            this.lblResize.Size = new System.Drawing.Size(121, 13);
            this.lblResize.TabIndex = 5;
            this.lblResize.Text = "Resize (Width x Height):";
            // 
            // txtResizeWidth
            // 
            this.txtResizeWidth.Location = new System.Drawing.Point(150, 100);
            this.txtResizeWidth.Name = "txtResizeWidth";
            this.txtResizeWidth.Size = new System.Drawing.Size(80, 20);
            this.txtResizeWidth.TabIndex = 6;
            this.txtResizeWidth.TextChanged += new System.EventHandler(this.txtResizeWidth_TextChanged);
            // 
            // txtResizeHeight
            // 
            this.txtResizeHeight.Location = new System.Drawing.Point(240, 100);
            this.txtResizeHeight.Name = "txtResizeHeight";
            this.txtResizeHeight.Size = new System.Drawing.Size(80, 20);
            this.txtResizeHeight.TabIndex = 7;
            this.txtResizeHeight.TextChanged += new System.EventHandler(this.txtResizeHeight_TextChanged);
            // 
            // rbBMP
            // 
            this.rbBMP.AutoSize = true;
            this.rbBMP.Location = new System.Drawing.Point(69, 48);
            this.rbBMP.Name = "rbBMP";
            this.rbBMP.Size = new System.Drawing.Size(55, 20);
            this.rbBMP.TabIndex = 13;
            this.rbBMP.TabStop = true;
            this.rbBMP.Text = "BMP";
            this.rbBMP.UseVisualStyleBackColor = true;
            this.rbBMP.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // rbTIFF
            // 
            this.rbTIFF.AutoSize = true;
            this.rbTIFF.Location = new System.Drawing.Point(6, 48);
            this.rbTIFF.Name = "rbTIFF";
            this.rbTIFF.Size = new System.Drawing.Size(54, 20);
            this.rbTIFF.TabIndex = 14;
            this.rbTIFF.TabStop = true;
            this.rbTIFF.Text = "TIFF";
            this.rbTIFF.UseVisualStyleBackColor = true;
            this.rbTIFF.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // rbPAM
            // 
            this.rbPAM.AutoSize = true;
            this.rbPAM.Location = new System.Drawing.Point(6, 75);
            this.rbPAM.Name = "rbPAM";
            this.rbPAM.Size = new System.Drawing.Size(55, 20);
            this.rbPAM.TabIndex = 15;
            this.rbPAM.TabStop = true;
            this.rbPAM.Text = "PAM";
            this.rbPAM.UseVisualStyleBackColor = true;
            this.rbPAM.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // rbPPM
            // 
            this.rbPPM.AutoSize = true;
            this.rbPPM.Location = new System.Drawing.Point(6, 102);
            this.rbPPM.Name = "rbPPM";
            this.rbPPM.Size = new System.Drawing.Size(55, 20);
            this.rbPPM.TabIndex = 16;
            this.rbPPM.TabStop = true;
            this.rbPPM.Text = "PPM";
            this.rbPPM.UseVisualStyleBackColor = true;
            this.rbPPM.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // rbPGM
            // 
            this.rbPGM.AutoSize = true;
            this.rbPGM.Location = new System.Drawing.Point(6, 129);
            this.rbPGM.Name = "rbPGM";
            this.rbPGM.Size = new System.Drawing.Size(56, 20);
            this.rbPGM.TabIndex = 17;
            this.rbPGM.TabStop = true;
            this.rbPGM.Text = "PGM";
            this.rbPGM.UseVisualStyleBackColor = true;
            this.rbPGM.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // rbYUV
            // 
            this.rbYUV.AutoSize = true;
            this.rbYUV.Location = new System.Drawing.Point(70, 21);
            this.rbYUV.Name = "rbYUV";
            this.rbYUV.Size = new System.Drawing.Size(54, 20);
            this.rbYUV.TabIndex = 18;
            this.rbYUV.TabStop = true;
            this.rbYUV.Text = "YUV";
            this.rbYUV.UseVisualStyleBackColor = true;
            this.rbYUV.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // grpOutputFormat
            // 
            this.grpOutputFormat.Controls.Add(this.rbBMP);
            this.grpOutputFormat.Controls.Add(this.rbTIFF);
            this.grpOutputFormat.Controls.Add(this.rbPAM);
            this.grpOutputFormat.Controls.Add(this.rbPPM);
            this.grpOutputFormat.Controls.Add(this.rbPGM);
            this.grpOutputFormat.Controls.Add(this.rbYUV);
            this.grpOutputFormat.Controls.Add(this.rbPNG);
            this.grpOutputFormat.Location = new System.Drawing.Point(22, 140);
            this.grpOutputFormat.Name = "grpOutputFormat";
            this.grpOutputFormat.Size = new System.Drawing.Size(380, 150);
            this.grpOutputFormat.TabIndex = 9;
            this.grpOutputFormat.TabStop = false;
            this.grpOutputFormat.Text = "Output Format";
            // 
            // rbPNG
            // 
            this.rbPNG.AutoSize = true;
            this.rbPNG.Checked = true;
            this.rbPNG.Location = new System.Drawing.Point(6, 21);
            this.rbPNG.Name = "rbPNG";
            this.rbPNG.Size = new System.Drawing.Size(55, 20);
            this.rbPNG.TabIndex = 19;
            this.rbPNG.TabStop = true;
            this.rbPNG.Text = "PNG";
            this.rbPNG.UseVisualStyleBackColor = true;
            this.rbPNG.CheckedChanged += new System.EventHandler(this.OutputFormat_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 521);
            this.Controls.Add(this.grpOutputFormat);
            this.Controls.Add(this.txtResizeHeight);
            this.Controls.Add(this.txtResizeWidth);
            this.Controls.Add(this.lblResize);
            this.Controls.Add(this.chkMultiThreading);
            this.Controls.Add(this.txtCommandPreview);
            this.Controls.Add(this.lblCommandPreview);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.lblInputFile);
            this.Name = "Form1";
            this.Text = "DWebP GUI";
            this.grpOutputFormat.ResumeLayout(false);
            this.grpOutputFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
