namespace TextLength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = richTextBox1.Text.Length;
            label2.Text = $"Text Length is : {length}";
            label2.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            richTextBox1.Text = "";
        }
    }
}