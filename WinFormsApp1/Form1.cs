namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBai01 f = new FormBai01();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai02 f = new FormBai02();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBai03 f = new FormBai03();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBai04 f = new FormBai04();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai05 f = new FormBai05();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai06 f = new FormBai06();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormBai07 f = new FormBai07();
            f.ShowDialog();
        }
    }
}
