namespace ClassExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value1 = int.Parse(this.textBox1.Text);
            var value2 = int.Parse(this.textBox2.Text);

            var result = value1 + value2;

            this.lblResult.Text = result.ToString();
        }
    }
}
