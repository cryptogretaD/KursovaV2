using KursovaV2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Rectangle = KursovaV2.Forms.Rectangle;

namespace KursovaV2.Windows
{
    public partial class ChangeColor : Form
    {
        public Scene Scene { get; private set; }

        public ChangeColor(Scene scene)
        {
            InitializeComponent();
            Scene = scene;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            ChooseColorForShape(typeof(Rectangle));
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            ChooseColorForShape(typeof(Triangle));
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            ChooseColorForShape(typeof(Circle));
        }

        private void ChooseColorForShape(Type shapeType)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Scene.UpdateShapeColors(shapeType, dialog.Color);
                    this.Close();

                }
            }
        }
    }
}
