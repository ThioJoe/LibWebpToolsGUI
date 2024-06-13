namespace cWebpGUI
{
    partial class cWebpGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cWebpGUI));
            this.lblInputFile = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.chkLossless = new System.Windows.Forms.CheckBox();
            this.chkMultiThreading = new System.Windows.Forms.CheckBox();
            this.chkLowMemory = new System.Windows.Forms.CheckBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.lblAlphaQuality = new System.Windows.Forms.Label();
            this.txtAlphaQuality = new System.Windows.Forms.TextBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCommandPreview = new System.Windows.Forms.Label();
            this.txtCommandPreview = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(12, 15);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(50, 13);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input File";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(100, 12);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(162, 20);
            this.txtInputFile.TabIndex = 1;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(12, 41);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(58, 13);
            this.lblOutputFile.TabIndex = 2;
            this.lblOutputFile.Text = "Output File";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(100, 38);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(162, 20);
            this.txtOutputFile.TabIndex = 3;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // chkLossless
            // 
            this.chkLossless.AutoSize = true;
            this.chkLossless.Location = new System.Drawing.Point(15, 70);
            this.chkLossless.Name = "chkLossless";
            this.chkLossless.Size = new System.Drawing.Size(66, 17);
            this.chkLossless.TabIndex = 4;
            this.chkLossless.Text = "Lossless";
            this.chkLossless.UseVisualStyleBackColor = true;
            this.chkLossless.CheckedChanged += new System.EventHandler(this.chkLossless_CheckedChanged);
            // 
            // chkMultiThreading
            // 
            this.chkMultiThreading.AutoSize = true;
            this.chkMultiThreading.Location = new System.Drawing.Point(15, 93);
            this.chkMultiThreading.Name = "chkMultiThreading";
            this.chkMultiThreading.Size = new System.Drawing.Size(99, 17);
            this.chkMultiThreading.TabIndex = 5;
            this.chkMultiThreading.Text = "Multi-Threading";
            this.chkMultiThreading.UseVisualStyleBackColor = true;
            this.chkMultiThreading.CheckedChanged += new System.EventHandler(this.chkMultiThreading_CheckedChanged);
            // 
            // chkLowMemory
            // 
            this.chkLowMemory.AutoSize = true;
            this.chkLowMemory.Location = new System.Drawing.Point(15, 116);
            this.chkLowMemory.Name = "chkLowMemory";
            this.chkLowMemory.Size = new System.Drawing.Size(86, 17);
            this.chkLowMemory.TabIndex = 6;
            this.chkLowMemory.Text = "Low Memory";
            this.chkLowMemory.UseVisualStyleBackColor = true;
            this.chkLowMemory.CheckedChanged += new System.EventHandler(this.chkLowMemory_CheckedChanged);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(12, 145);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(75, 13);
            this.lblQuality.TabIndex = 7;
            this.lblQuality.Text = "Quality (0-100)";
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(100, 142);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 20);
            this.txtQuality.TabIndex = 8;
            this.txtQuality.TextChanged += new System.EventHandler(this.txtQuality_TextChanged);
            // 
            // lblAlphaQuality
            // 
            this.lblAlphaQuality.AutoSize = true;
            this.lblAlphaQuality.Location = new System.Drawing.Point(12, 171);
            this.lblAlphaQuality.Name = "lblAlphaQuality";
            this.lblAlphaQuality.Size = new System.Drawing.Size(69, 13);
            this.lblAlphaQuality.TabIndex = 9;
            this.lblAlphaQuality.Text = "Alpha Quality";
            // 
            // txtAlphaQuality
            // 
            this.txtAlphaQuality.Location = new System.Drawing.Point(100, 168);
            this.txtAlphaQuality.Name = "txtAlphaQuality";
            this.txtAlphaQuality.Size = new System.Drawing.Size(100, 20);
            this.txtAlphaQuality.TabIndex = 10;
            this.txtAlphaQuality.TextChanged += new System.EventHandler(this.txtAlphaQuality_TextChanged);
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(12, 197);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(37, 13);
            this.lblPreset.TabIndex = 11;
            this.lblPreset.Text = "Preset";
            // 
            // cmbPreset
            // 
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Items.AddRange(new object[] {
            "",
            "default",
            "photo",
            "picture",
            "drawing",
            "icon",
            "text"});
            this.cmbPreset.Location = new System.Drawing.Point(100, 195);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(100, 21);
            this.cmbPreset.TabIndex = 12;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(12, 224);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 13;
            this.lblMethod.Text = "Method";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4 (Default)",
            "5",
            "6"});
            this.cmbMethod.Location = new System.Drawing.Point(100, 224);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(68, 21);
            this.cmbMethod.TabIndex = 14;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(15, 260);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 15;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCommandPreview
            // 
            this.lblCommandPreview.AutoSize = true;
            this.lblCommandPreview.Location = new System.Drawing.Point(12, 300);
            this.lblCommandPreview.Name = "lblCommandPreview";
            this.lblCommandPreview.Size = new System.Drawing.Size(98, 13);
            this.lblCommandPreview.TabIndex = 16;
            this.lblCommandPreview.Text = "Command Preview:";
            // 
            // txtCommandPreview
            // 
            this.txtCommandPreview.Location = new System.Drawing.Point(15, 320);
            this.txtCommandPreview.Multiline = true;
            this.txtCommandPreview.Name = "txtCommandPreview";
            this.txtCommandPreview.ReadOnly = true;
            this.txtCommandPreview.Size = new System.Drawing.Size(260, 60);
            this.txtCommandPreview.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, 168);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(211, 198);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Specify a set of pre-defined parameters to suit a particular type of source mater" +
        "ial.\r\n\r\nThis will override other parameter values (except Quality)");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(211, 227);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(265, 10);
            this.btnBrowseInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(65, 21);
            this.btnBrowseInput.TabIndex = 22;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Images|*png;*.jpg;*.jpeg;.tif;*.tiff;*.yuv|JPEG Image|*.jpg;*.jpeg|PNG Image|" +
    "*.png|TIFF Image|*.tif;*tiff|YUV Image|*.yuv";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(265, 34);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(65, 21);
            this.btnBrowseOutput.TabIndex = 23;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "WebP Image|*.webp";
            // 
            // cWebpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 400);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCommandPreview);
            this.Controls.Add(this.lblCommandPreview);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.cmbPreset);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.txtAlphaQuality);
            this.Controls.Add(this.lblAlphaQuality);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.chkLowMemory);
            this.Controls.Add(this.chkMultiThreading);
            this.Controls.Add(this.chkLossless);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.lblInputFile);
            this.Name = "cWebpGUI";
            this.Text = "cWebp GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.CheckBox chkLossless;
        private System.Windows.Forms.CheckBox chkMultiThreading;
        private System.Windows.Forms.CheckBox chkLowMemory;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label lblAlphaQuality;
        private System.Windows.Forms.TextBox txtAlphaQuality;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCommandPreview;
        private System.Windows.Forms.TextBox txtCommandPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}