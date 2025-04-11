namespace KursovaV2.Windows
{
    partial class CircleParams
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
            diameterLabel = new Label();
            diameterTextBox = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // diameterLabel
            // 
            diameterLabel.AutoSize = true;
            diameterLabel.Location = new Point(23, 32);
            diameterLabel.Name = "diameterLabel";
            diameterLabel.Size = new Size(71, 20);
            diameterLabel.TabIndex = 0;
            diameterLabel.Text = "Diameter";
            // 
            // diameterTextBox
            // 
            diameterTextBox.Location = new Point(27, 84);
            diameterTextBox.Name = "diameterTextBox";
            diameterTextBox.Size = new Size(392, 27);
            diameterTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(155, 390);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // CircleParams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 525);
            Controls.Add(okButton);
            Controls.Add(diameterTextBox);
            Controls.Add(diameterLabel);
            Name = "CircleParams";
            Text = "CircleParams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label diameterLabel;
        private TextBox diameterTextBox;
        private Button okButton;
    }
}