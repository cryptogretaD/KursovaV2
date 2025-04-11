using System;
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
    namespace KursovaV2.Windows
    {
        public partial class Beginning : Form
        {
            public Beginning() // Constructor for the form
            {
                InitializeCustomUI(); // Call the method to initialize custom UI components
            }

            private void InitializeCustomUI()
            {
                this.Text = "Choose a Shape";
                this.Size = new Size(300, 150);
                this.StartPosition = FormStartPosition.CenterScreen;

                Button rectangleButton = new Button
                {
                    Text = "Rectangle",
                    Size = new Size(200, 40),
                    Location = new Point(50, 50)
                };

                // Assign event handler to the Rectangle button's click event
                rectangleButton.Click += rectangleButton_Click;

                this.Controls.Add(rectangleButton); // Add the button to the form
            }

            // Event handler for the button click
            private void rectangleButton_Click(object sender, EventArgs e)
            {
                RectangleParams rp = new RectangleParams(); // Create instance of RectangleParams
                this.Hide(); // Hide the current form (Beginning)
                rp.Show(); // Show the RectangleParams form
            }
        }
    }
}