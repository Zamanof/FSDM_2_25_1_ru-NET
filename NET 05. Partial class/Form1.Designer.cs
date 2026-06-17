namespace NET_05._Partial_class
{
    partial class Form1
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
            countButton = new Button();
            countLabel = new Label();
            SuspendLayout();
            // 
            // countButton
            // 
            countButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countButton.Location = new Point(315, 221);
            countButton.Name = "countButton";
            countButton.Size = new Size(160, 63);
            countButton.TabIndex = 0;
            countButton.Text = "Click me";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += countButton_Click;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countLabel.Location = new Point(377, 130);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(42, 50);
            countLabel.TabIndex = 1;
            countLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countLabel);
            Controls.Add(countButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button countButton;
        private Label countLabel;
    }
}
