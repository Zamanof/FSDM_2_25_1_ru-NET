namespace NET_12._EventArgs_Winform
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addButton = new Button();
            subtractButton = new Button();
            multipleButton = new Button();
            divideButton = new Button();
            label1 = new Label();
            label2 = new Label();
            resultLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(112, 102);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += Calculator;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(112, 131);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 23);
            subtractButton.TabIndex = 1;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += Calculator;
            // 
            // multipleButton
            // 
            multipleButton.Location = new Point(112, 160);
            multipleButton.Name = "multipleButton";
            multipleButton.Size = new Size(75, 23);
            multipleButton.TabIndex = 1;
            multipleButton.Text = "Multiple";
            multipleButton.UseVisualStyleBackColor = true;
            multipleButton.Click += Calculator;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(112, 189);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 23);
            divideButton.TabIndex = 1;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += Calculator;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 13);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 71);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Result:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(159, 71);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(13, 15);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 13);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 2;
            label4.Text = "Second";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 244);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(divideButton);
            Controls.Add(multipleButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button addButton;
        private Button subtractButton;
        private Button multipleButton;
        private Button divideButton;
        private Label label1;
        private Label label2;
        private Label resultLabel;
        private Label label4;
    }
}
