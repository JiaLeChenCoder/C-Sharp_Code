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

namespace _1_29_TextDialogDox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的对话框";//标题设置
            ofd.Multiselect = true;//设置多选
            ofd.InitialDirectory = @"C:\Users\陈家乐\Desktop";//设置对话框的初始目录
            ofd.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();//展示对话框
            //获得在打开对话框中选中文件的路径
            string path = ofd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)) 
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);//实际读的字节数
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }

        }
    }
}
