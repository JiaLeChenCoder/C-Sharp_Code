namespace _1_8_MouseEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��Ҳ��˧");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���ԣ������");
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - btnUnLove.Width;
            int y = this.ClientSize.Height - btnUnLove.Height;
            Random r = new Random();
            btnUnLove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}