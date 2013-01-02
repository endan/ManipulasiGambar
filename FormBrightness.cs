using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManipulasiGambar
{
    public partial class FormBrightness : Form
    {
        public FormBrightness()
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        public int BrightnessValue
        {
            get 
            {
                if (string.IsNullOrEmpty(txtBrightnessValue.Text))
                    txtBrightnessValue.Text = "0";
                return Convert.ToInt32(txtBrightnessValue.Text); 
            }
            set { txtBrightnessValue.Text = value.ToString(); }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}