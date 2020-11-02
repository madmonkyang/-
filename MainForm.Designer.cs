namespace 条码打印器
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodeString = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBoxBarCode = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFontSize = new System.Windows.Forms.TextBox();
            this.tbBarCodeSpacing = new System.Windows.Forms.TextBox();
            this.tbBarcodeHeight = new System.Windows.Forms.TextBox();
            this.tbBarCodeWidth = new System.Windows.Forms.TextBox();
            this.lbBarCodes = new System.Windows.Forms.ListBox();
            this.btnBatchPrint = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbPrinters = new System.Windows.Forms.ComboBox();
            this.btnPageSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodeString
            // 
            this.tbCodeString.Location = new System.Drawing.Point(17, 58);
            this.tbCodeString.Name = "tbCodeString";
            this.tbCodeString.Size = new System.Drawing.Size(203, 21);
            this.tbCodeString.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(227, 57);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBoxBarCode
            // 
            this.pictureBoxBarCode.Location = new System.Drawing.Point(308, 57);
            this.pictureBoxBarCode.Name = "pictureBoxBarCode";
            this.pictureBoxBarCode.Size = new System.Drawing.Size(350, 100);
            this.pictureBoxBarCode.TabIndex = 2;
            this.pictureBoxBarCode.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(227, 86);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单条打印";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPageSetting);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbFontSize);
            this.groupBox2.Controls.Add(this.tbBarCodeSpacing);
            this.groupBox2.Controls.Add(this.tbBarcodeHeight);
            this.groupBox2.Controls.Add(this.tbBarCodeWidth);
            this.groupBox2.Controls.Add(this.lbBarCodes);
            this.groupBox2.Controls.Add(this.btnBatchPrint);
            this.groupBox2.Controls.Add(this.btnOpenFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "批量打印";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "字体大小";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "条码间距";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "条码高度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "条码宽度";
            // 
            // tbFontSize
            // 
            this.tbFontSize.Location = new System.Drawing.Point(64, 131);
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(100, 21);
            this.tbFontSize.TabIndex = 14;
            this.tbFontSize.Text = "12";
            this.tbFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatingNumber);
            // 
            // tbBarCodeSpacing
            // 
            this.tbBarCodeSpacing.Location = new System.Drawing.Point(64, 104);
            this.tbBarCodeSpacing.Name = "tbBarCodeSpacing";
            this.tbBarCodeSpacing.Size = new System.Drawing.Size(100, 21);
            this.tbBarCodeSpacing.TabIndex = 13;
            this.tbBarCodeSpacing.Text = "50";
            this.tbBarCodeSpacing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatingNumber);
            // 
            // tbBarcodeHeight
            // 
            this.tbBarcodeHeight.Location = new System.Drawing.Point(64, 77);
            this.tbBarcodeHeight.Name = "tbBarcodeHeight";
            this.tbBarcodeHeight.Size = new System.Drawing.Size(100, 21);
            this.tbBarcodeHeight.TabIndex = 12;
            this.tbBarcodeHeight.Text = "100";
            this.tbBarcodeHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatingNumber);
            // 
            // tbBarCodeWidth
            // 
            this.tbBarCodeWidth.Location = new System.Drawing.Point(64, 50);
            this.tbBarCodeWidth.Name = "tbBarCodeWidth";
            this.tbBarCodeWidth.Size = new System.Drawing.Size(100, 21);
            this.tbBarCodeWidth.TabIndex = 11;
            this.tbBarCodeWidth.Text = "300";
            this.tbBarCodeWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatingNumber);
            // 
            // lbBarCodes
            // 
            this.lbBarCodes.FormattingEnabled = true;
            this.lbBarCodes.ItemHeight = 12;
            this.lbBarCodes.Location = new System.Drawing.Point(296, 15);
            this.lbBarCodes.Name = "lbBarCodes";
            this.lbBarCodes.Size = new System.Drawing.Size(350, 232);
            this.lbBarCodes.TabIndex = 1;
            // 
            // btnBatchPrint
            // 
            this.btnBatchPrint.Location = new System.Drawing.Point(89, 21);
            this.btnBatchPrint.Name = "btnBatchPrint";
            this.btnBatchPrint.Size = new System.Drawing.Size(75, 23);
            this.btnBatchPrint.TabIndex = 0;
            this.btnBatchPrint.Text = "批量打印";
            this.btnBatchPrint.UseVisualStyleBackColor = true;
            this.btnBatchPrint.Click += new System.EventHandler(this.btnBatchPrint_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(8, 21);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbPrinters
            // 
            this.cbPrinters.FormattingEnabled = true;
            this.cbPrinters.Location = new System.Drawing.Point(17, 8);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(285, 20);
            this.cbPrinters.TabIndex = 5;
            // 
            // btnPageSetting
            // 
            this.btnPageSetting.Location = new System.Drawing.Point(171, 21);
            this.btnPageSetting.Name = "btnPageSetting";
            this.btnPageSetting.Size = new System.Drawing.Size(75, 23);
            this.btnPageSetting.TabIndex = 15;
            this.btnPageSetting.Text = "页面设置";
            this.btnPageSetting.UseVisualStyleBackColor = true;
            this.btnPageSetting.Click += new System.EventHandler(this.btnPageSetting_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.cbPrinters);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxBarCode);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbCodeString);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "条码打印器  by Mei";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodeString;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBoxBarCode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBatchPrint;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbPrinters;
        private System.Windows.Forms.ListBox lbBarCodes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFontSize;
        private System.Windows.Forms.TextBox tbBarCodeSpacing;
        private System.Windows.Forms.TextBox tbBarcodeHeight;
        private System.Windows.Forms.TextBox tbBarCodeWidth;
        private System.Windows.Forms.Button btnPageSetting;
    }
}

