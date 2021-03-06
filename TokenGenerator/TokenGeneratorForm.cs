﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenGenerator.UserServices;

namespace TokenGenerator
{
    public partial class TokenGeneratorForm : Form
    {
        public TokenGeneratorForm()
        {
            InitializeComponent();
            txtTokenOutput.ForeColor = Color.Black;
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            txtTokenOutput.ForeColor = Color.Black;
            try
            {
                using (var client = new UserServicesClient())
                {
                    txtTokenOutput.Text = client.GenerateToken();
                }
            }
            catch (Exception ex)
            {
                var msg = string.Format("An error occurred while generating the token {0}", ex.Message);
                txtTokenOutput.Text = msg;//@"An error occurred while generating the token {ex.Message}";
                txtTokenOutput.Font = new Font(txtTokenOutput.Font.FontFamily, 10);
                txtTokenOutput.ForeColor = Color.Red;
            }
        }
    }
}