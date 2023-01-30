using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1_30_SaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的路径";
            sfd.InitialDirectory = @"C:\Users\陈家乐\Desktop";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";//类型
            sfd.ShowDialog();
            string path = sfd.FileName;//获取保存文件的路径
            if (path == "")
            {
                return;
            }
            using (FileStream fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
