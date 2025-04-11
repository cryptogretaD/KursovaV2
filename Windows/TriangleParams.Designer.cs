namespace KursovaV2.Windows
{
    partial class TriangleParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            widthLabel = new Label();
            widthTextBox = new TextBox();
            heightLabel = new Label();
            heightTextBox = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(30, 47);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(49, 20);
            widthLabel.TabIndex = 2;
            widthLabel.Text = "Width";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(30, 88);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(466, 27);
            widthTextBox.TabIndex = 3;
            widthTextBox.Text = " ";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(30, 167);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(54, 20);
            heightLabel.TabIndex = 4;
            heightLabel.Text = "Height";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(30, 213);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(466, 27);
            heightTextBox.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new Point(186, 430);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // TriangleParams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 555);
            Controls.Add(okButton);
            Controls.Add(heightTextBox);
            Controls.Add(heightLabel);
            Controls.Add(widthTextBox);
            Controls.Add(widthLabel);
            Name = "TriangleParams";
            Text = "TriangleParams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label widthLabel;
        private TextBox widthTextBox;
        private Label heightLabel;
        private TextBox heightTextBox;
        private Button okButton;
    }
}