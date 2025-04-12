using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursovaV2.Scene;

namespace KursovaV2.Windows
{
    public partial class RectangleParams : Form
    {
        public RectangleParams()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(widthTextBox.Text) || string.IsNullOrWhiteSpace(heightTextBox.Text))
            {
                MessageBox.Show("Cannot enter null value", "Error");
                return;
            }

            if (!int.TryParse(widthTextBox.Text, out int width) || !int.TryParse(heightTextBox.Text, out int height))
            {
                MessageBox.Show("Please enter valid numbers", "Error");
                return;
            }

            ((Scene)this.Owner).SetStartingShape(ShapeType.Rectangle);
            this.Hide();
        }
    }
}