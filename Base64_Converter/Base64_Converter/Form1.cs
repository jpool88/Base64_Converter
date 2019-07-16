using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64_Converter
{
    public partial class Form_Base64_Converter : Form
    {
        private string InputTextNull;
        public Form_Base64_Converter()
        {
            InitializeComponent();
            InputTextNull = $"{lbl1} must be populated";
        }

        #region String
        private void BtnEncodeString_Click_1(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInputString.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }

            var plainTextBytes = Encoding.UTF8.GetBytes(txtInputString.Text);
            txtOutputString.Text = Convert.ToBase64String(plainTextBytes);
        }

        private void BtnDecodeString_Click_1(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInputString.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }

            var base64EncodedBytes = Convert.FromBase64String(txtInputString.Text);
            txtOutputString.Text = Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void BtnCopyString_Click_1(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtOutputString.Text);
            if (nullGuard != false)
                return;

            Clipboard.SetText(txtOutputString.Text);
        }
        #endregion String

        private bool NullCheck(string value)
        {
            return value == "";
        }

        #region File Encoding
        private void BtnEncodeFile_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInputFile.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }
            //Add check for valid file path

            Byte[] bytes = File.ReadAllBytes(txtInputFile.Text);
            txtEncodedFile.Text = Convert.ToBase64String(bytes);
        }

        private void BtnCopyFile_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtEncodedFile.Text);
            if (nullGuard != false)
                return;

            Clipboard.SetText(txtEncodedFile.Text);
        }

        #endregion File Encoding
        
    }
}