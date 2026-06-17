namespace NET_05._Partial_class
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
        }
    }
}
