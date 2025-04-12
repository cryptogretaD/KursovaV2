using static KursovaV2.Scene;

namespace KursovaV2.Windows
{
    public partial class Beginning : Form
    {
        public Beginning()
        {
            InitializeCustomUI();
        }

        private void InitializeCustomUI()
        {
            this.Text = "Choose a Shape to Start Drawing";
            this.Size = new Size(300, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button rectangleBtn = new Button
            {
                Text = "Start with Rectangle",
                Size = new Size(200, 40),
                Location = new Point(50, 30)
            };
            rectangleBtn.Click += RectangleBtn_Click;

            Button triangleBtn = new Button
            {
                Text = "Start with Triangle",
                Size = new Size(200, 40),
                Location = new Point(50, 90)
            };
            triangleBtn.Click += TriangleBtn_Click;

            Button circleBtn = new Button
            {
                Text = "Start with Circle",
                Size = new Size(200, 40),
                Location = new Point(50, 150)
            };
            circleBtn.Click += CircleBtn_Click;

            this.Controls.Add(rectangleBtn);
            this.Controls.Add(triangleBtn);
            this.Controls.Add(circleBtn);
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Scene scene = new Scene(100, 150); // height, width
            scene.SetStartingShape(ShapeType.Rectangle);
            this.Hide();
            scene.Show();
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            Scene scene = new Scene(100, 150);
            scene.SetStartingShape(ShapeType.Triangle);
            this.Hide();
            scene.Show();
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            Scene scene = new Scene(100, 150);
            scene.SetStartingShape(ShapeType.Circle);
            this.Hide();
            scene.Show();
        }

        private void InitializeComponent()
        {

        }
    }
}