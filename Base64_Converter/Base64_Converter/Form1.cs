using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInput.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }

            var plainTextBytes = Encoding.UTF8.GetBytes(txtInput.Text);
           txtOutput.Text = Convert.ToBase64String(plainTextBytes);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtOutput.Text);
            if (nullGuard != false)
                return;

            Clipboard.SetText(txtOutput.Text);
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInput.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }

            var base64EncodedBytes = Convert.FromBase64String(txtInput.Text);
            txtOutput.Text = Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private bool NullCheck(string value)
        {
            return value == "";
        }

    }
}
