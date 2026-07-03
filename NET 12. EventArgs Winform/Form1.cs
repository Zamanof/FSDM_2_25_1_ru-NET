namespace NET_12._EventArgs_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double result = 0;
            if (button.Text == "Add")
            {
                result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            }
            else if (button.Text == "Subtract")
            {
                result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            }
            else if (button.Text == "Multiple")
            {
                result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            }
            else if (button.Text == "Divide")
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            }
            resultLabel.Text = result.ToString();
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
