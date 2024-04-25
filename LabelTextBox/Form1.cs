namespace LabelTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Текст:  ";
                label1.Text += textBox1.Text;
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Текст:  ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Текст:  ";
                label1.Text += textBox1.Text;
            }
            catch (Exception)
            {


            }
        }
    }
}
