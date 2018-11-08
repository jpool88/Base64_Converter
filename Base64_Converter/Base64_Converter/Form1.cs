﻿using System;
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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var nullGuard = NullCheck(txtInput.Text);
            if (nullGuard != false)
            {
                MessageBox.Show(InputTextNull, "Error");
                return;
            }
                

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(txtInput.Text);
           txtOutput.Text = Convert.ToBase64String(plainTextBytes);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private bool NullCheck(string value)
        {
            return value == "";
        }
    }
}
