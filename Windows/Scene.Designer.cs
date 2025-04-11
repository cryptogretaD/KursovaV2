namespace KursovaV2
{
    partial class Scene
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            squareButton = new Button();
            triangleButton = new Button();
            SuspendLayout();
            // 
            // squareButton
            // 
            squareButton.Location = new Point(694, 29);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(94, 29);
            squareButton.TabIndex = 0;
            squareButton.Text = "Square";
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += Square_Click;
            // 
            // triangleButton
            // 
            triangleButton.Location = new Point(698, 79);
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(94, 29);
            triangleButton.TabIndex = 1;
            triangleButton.Text = "Triangle";
            triangleButton.UseVisualStyleBackColor = true;
            // 
            // Scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 506);
            Controls.Add(triangleButton);
            Controls.Add(squareButton);
            Name = "Scene";
            Text = "Scene";
            MouseClick += Scene_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button squareButton;
        private Button triangleButton;
    }
}
