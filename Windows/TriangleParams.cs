﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaV2.Windows
{
    public partial class TriangleParams : Form
    {
        public TriangleParams()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (widthTextBox.Text == "" || heightTextBox.Text == "")
            {
                MessageBox.Show("Cannot enter null value", "Error");
            }
            else
            {
                int width = int.Parse(widthTextBox.Text);
                int height = int.Parse(heightTextBox.Text);

                Scene sc = new Scene(height, width);
                this.Hide();
                sc.Show();
            }
        }
    }
}
