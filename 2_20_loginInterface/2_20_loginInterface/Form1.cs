using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_20_loginInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPassword.Text;
            if (name == "陈家乐" && pwd == "chenjiale")
            {
                label1.Visible = false;//用户名不显示
                label2.Visible = false;//密码不显示
                txtName.Visible = false;//用户名后文本不显示
                txtPassword.Visible = false;//密码后文本不显示
                btnLogin.Visible = false;//登录不显示
                MessageBox.Show("登录成功");
            }
            else if (name == "")
            {
                MessageBox.Show("用户名为空");
            }
            else
            {
                MessageBox.Show("登陆失败");
                txtName.Clear();
                txtPassword.Clear();
                txtName.Focus();   
            }
        }
    }
}
