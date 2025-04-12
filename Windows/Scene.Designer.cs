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
            cangeColorButton = new Button();
            squareButton = new Button();
            triangleButton = new Button();
            closeButton = new Button();
            CircleButton = new Button();
            colorDialog = new ColorDialog();
            SuspendLayout();
            // 
            // cangeColorButton
            // 
            cangeColorButton.Location = new Point(553, 465);
            cangeColorButton.Name = "cangeColorButton";
            cangeColorButton.Size = new Size(123, 29);
            cangeColorButton.TabIndex = 4;
            cangeColorButton.Text = "Change color";
            cangeColorButton.UseVisualStyleBackColor = true;
            cangeColorButton.Click += cangeColorButton_Click;
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
            triangleButton.Click += Triangle_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(698, 465);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // CircleButton
            // 
            CircleButton.Location = new Point(694, 134);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(94, 29);
            CircleButton.TabIndex = 3;
            CircleButton.Text = "Circle";
            CircleButton.UseVisualStyleBackColor = true;
            CircleButton.Click += Circle_Click;
            // 
            // Scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 506);
            Controls.Add(cangeColorButton);
            Controls.Add(CircleButton);
            Controls.Add(closeButton);
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
        private Button closeButton;
        private Button CircleButton;
        private Button cangeColorButton;
        private ColorDialog colorDialog;
        private System.Windows.Forms.Button changeColorButton;
    }
}
