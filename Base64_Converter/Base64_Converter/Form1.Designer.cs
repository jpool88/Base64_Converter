namespace Base64_Converter
{
    partial class Form_Base64_Converter
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCont1 = new System.Windows.Forms.TabControl();
            this.tPg1 = new System.Windows.Forms.TabPage();
            this.btnDecodeString = new System.Windows.Forms.Button();
            this.btnCopyString = new System.Windows.Forms.Button();
            this.btnEncodeString = new System.Windows.Forms.Button();
            this.txtOutputString = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tPg2 = new System.Windows.Forms.TabPage();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnEncodeFile = new System.Windows.Forms.Button();
            this.txtEncodedFile = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tCont1.SuspendLayout();
            this.tPg1.SuspendLayout();
            this.tPg2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCont1
            // 
            this.tCont1.Controls.Add(this.tPg1);
            this.tCont1.Controls.Add(this.tPg2);
            this.tCont1.Location = new System.Drawing.Point(12, 12);
            this.tCont1.Name = "tCont1";
            this.tCont1.SelectedIndex = 0;
            this.tCont1.Size = new System.Drawing.Size(864, 239);
            this.tCont1.TabIndex = 7;
            // 
            // tPg1
            // 
            this.tPg1.Controls.Add(this.btnDecodeString);
            this.tPg1.Controls.Add(this.btnCopyString);
            this.tPg1.Controls.Add(this.btnEncodeString);
            this.tPg1.Controls.Add(this.txtOutputString);
            this.tPg1.Controls.Add(this.lbl2);
            this.tPg1.Controls.Add(this.txtInputString);
            this.tPg1.Controls.Add(this.lbl1);
            this.tPg1.Location = new System.Drawing.Point(4, 22);
            this.tPg1.Name = "tPg1";
            this.tPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tPg1.Size = new System.Drawing.Size(856, 213);
            this.tPg1.TabIndex = 0;
            this.tPg1.Text = "String";
            this.tPg1.UseVisualStyleBackColor = true;
            // 
            // btnDecodeString
            // 
            this.btnDecodeString.Location = new System.Drawing.Point(187, 170);
            this.btnDecodeString.Name = "btnDecodeString";
            this.btnDecodeString.Size = new System.Drawing.Size(148, 26);
            this.btnDecodeString.TabIndex = 13;
            this.btnDecodeString.Text = "Decode";
            this.btnDecodeString.UseVisualStyleBackColor = true;
            this.btnDecodeString.Click += new System.EventHandler(this.BtnDecodeString_Click_1);
            // 
            // btnCopyString
            // 
            this.btnCopyString.Location = new System.Drawing.Point(752, 115);
            this.btnCopyString.Name = "btnCopyString";
            this.btnCopyString.Size = new System.Drawing.Size(59, 28);
            this.btnCopyString.TabIndex = 12;
            this.btnCopyString.Text = "Copy";
            this.btnCopyString.UseVisualStyleBackColor = true;
            this.btnCopyString.Click += new System.EventHandler(this.BtnCopyString_Click_1);
            // 
            // btnEncodeString
            // 
            this.btnEncodeString.Location = new System.Drawing.Point(10, 170);
            this.btnEncodeString.Name = "btnEncodeString";
            this.btnEncodeString.Size = new System.Drawing.Size(148, 26);
            this.btnEncodeString.TabIndex = 11;
            this.btnEncodeString.Text = "Encode";
            this.btnEncodeString.UseVisualStyleBackColor = true;
            this.btnEncodeString.Click += new System.EventHandler(this.BtnEncodeString_Click_1);
            // 
            // txtOutputString
            // 
            this.txtOutputString.Location = new System.Drawing.Point(10, 120);
            this.txtOutputString.Multiline = true;
            this.txtOutputString.Name = "txtOutputString";
            this.txtOutputString.ReadOnly = true;
            this.txtOutputString.Size = new System.Drawing.Size(720, 20);
            this.txtOutputString.TabIndex = 10;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 94);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Output String";
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(10, 45);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(720, 20);
            this.txtInputString.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Input String";
            // 
            // tPg2
            // 
            this.tPg2.Controls.Add(this.btnCopyFile);
            this.tPg2.Controls.Add(this.btnEncodeFile);
            this.tPg2.Controls.Add(this.txtEncodedFile);
            this.tPg2.Controls.Add(this.lbl4);
            this.tPg2.Controls.Add(this.txtInputFile);
            this.tPg2.Controls.Add(this.lbl3);
            this.tPg2.Location = new System.Drawing.Point(4, 22);
            this.tPg2.Name = "tPg2";
            this.tPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tPg2.Size = new System.Drawing.Size(856, 213);
            this.tPg2.TabIndex = 1;
            this.tPg2.Text = "File Encoding";
            this.tPg2.UseVisualStyleBackColor = true;
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(752, 115);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(59, 28);
            this.btnCopyFile.TabIndex = 19;
            this.btnCopyFile.Text = "Copy";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.BtnCopyFile_Click);
            // 
            // btnEncodeFile
            // 
            this.btnEncodeFile.Location = new System.Drawing.Point(10, 170);
            this.btnEncodeFile.Name = "btnEncodeFile";
            this.btnEncodeFile.Size = new System.Drawing.Size(148, 26);
            this.btnEncodeFile.TabIndex = 18;
            this.btnEncodeFile.Text = "Encode";
            this.btnEncodeFile.UseVisualStyleBackColor = true;
            this.btnEncodeFile.Click += new System.EventHandler(this.BtnEncodeFile_Click);
            // 
            // txtEncodedFile
            // 
            this.txtEncodedFile.Location = new System.Drawing.Point(10, 120);
            this.txtEncodedFile.Multiline = true;
            this.txtEncodedFile.Name = "txtEncodedFile";
            this.txtEncodedFile.ReadOnly = true;
            this.txtEncodedFile.Size = new System.Drawing.Size(720, 20);
            this.txtEncodedFile.TabIndex = 17;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 94);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 13);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Encoded File";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(10, 45);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(720, 20);
            this.txtInputFile.TabIndex = 15;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 19);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(50, 13);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "Input File";
            // 
            // Form_Base64_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 260);
            this.Controls.Add(this.tCont1);
            this.Name = "Form_Base64_Converter";
            this.Text = "Base64_Converter";
            this.tCont1.ResumeLayout(false);
            this.tPg1.ResumeLayout(false);
            this.tPg1.PerformLayout();
            this.tPg2.ResumeLayout(false);
            this.tPg2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCont1;
        private System.Windows.Forms.TabPage tPg1;
        private System.Windows.Forms.Button btnDecodeString;
        private System.Windows.Forms.Button btnCopyString;
        private System.Windows.Forms.Button btnEncodeString;
        private System.Windows.Forms.TextBox txtOutputString;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TabPage tPg2;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button btnEncodeFile;
        private System.Windows.Forms.TextBox txtEncodedFile;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lbl3;
    }
}

