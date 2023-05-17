namespace Laba6
{
    public partial class Form1 : Form
    {
        MyList<int> intList = new MyList<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var num in intList)
            {
                textBox1.Text += num.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intList.push_back(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intList.push_back(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intList.push_back(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            intList.pop_front();
        }
    }

}