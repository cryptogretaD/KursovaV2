

namespace KursovaV2.Windows
{
    partial class ChangeColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private Button openColorSettingsButton;
        public Color CircleColor { get; set; } = Color.Red;
        public Color SquareColor { get; set; } = Color.Green;
        public Color TriangleColor { get; set; } = Color.Blue;
        public AutoScaleMode AutoScaleMode { get; private set; }
        public Size ClientSize { get; private set; }
        public string Text { get; private set; }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRectangle = new Button();
            btnTriangle = new Button();
            btnCircle = new Button();
            SuspendLayout();
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(174, 74);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(94, 29);
            btnRectangle.TabIndex = 0;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            btnTriangle.Location = new Point(180, 155);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(94, 29);
            btnTriangle.TabIndex = 1;
            btnTriangle.Text = "Triangle";
            btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            btnCircle.Location = new Point(181, 259);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(94, 29);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Circle";
            btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new EventHandler(this.btnCircle_Click);
            // 
            // ChangeColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCircle);
            Controls.Add(btnTriangle);
            Controls.Add(btnRectangle);
            Name = "ChangeColor";
            Text = "ChangeColor";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRectangle;
        private Button btnTriangle;
        private Button btnCircle;
    }
}