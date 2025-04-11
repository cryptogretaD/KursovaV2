namespace KursovaV2.Windows
{
    partial class RectangleParams: Form
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
            okButton = new Button();
            widthLabel = new Label();
            heigthLabel = new Label();
            widthTextBox = new TextBox();
            heightTextBox = new TextBox();
            heightLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(174, 351);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // widthLabel
            // 
            widthLabel.Location = new Point(0, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(100, 23);
            widthLabel.TabIndex = 6;
            // 
            // heigthLabel
            // 
            heigthLabel.Location = new Point(0, 0);
            heigthLabel.Name = "heigthLabel";
            heigthLabel.Size = new Size(100, 23);
            heigthLabel.TabIndex = 0;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(25, 81);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(396, 27);
            widthTextBox.TabIndex = 1;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(30, 214);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(391, 27);
            heightTextBox.TabIndex = 3;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(36, 180);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(54, 20);
            heightLabel.TabIndex = 5;
            heightLabel.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 46);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Width";
            // 
            // RectangleParams
            // 
            ClientSize = new Size(455, 444);
            Controls.Add(label2);
            Controls.Add(okButton);
            Controls.Add(heightTextBox);
            Controls.Add(widthTextBox);
            Controls.Add(heightLabel);
            Controls.Add(widthLabel);
            Name = "RectangleParams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rectangle Parameters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label widthLabel;
        private Label heigthLabel;
        private TextBox widthTextBox;
        private TextBox heightTextBox;
        private Label heightLabel;
        private Label label1;
        private Label label2;
    }

}