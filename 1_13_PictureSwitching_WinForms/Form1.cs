using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace _1_13_PictureSwitching_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\陈家乐\Desktop\运动会\1670309353890.jpg");
        }
        int i = 0;
        string[] path= Directory.GetFiles(@"C:\Users\陈家乐\Desktop\运动会");
        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}