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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(22, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Input String";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(26, 46);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(785, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(26, 121);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(785, 20);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Output String";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(26, 171);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(148, 26);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(830, 116);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(59, 28);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(203, 171);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(148, 26);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // Form_Base64_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 249);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbl1);
            this.Name = "Form_Base64_Converter";
            this.Text = "Base64_Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDecode;
    }
}

