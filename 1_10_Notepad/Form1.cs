using System.IO;
namespace _1_10_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnwordwrap.Visible = false;//自动换行不显示
            btnsave.Visible = false;//保存不显示
            txtwords.WordWrap = false;//大文本框不显示
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtname.Text.Trim();
            string userpwd = txtpwd.Text;
            if (userName == "陈家乐" && userpwd == "123456")
            {
                MessageBox.Show("登陆成功");
                label1.Visible = false;//用户名不显示
                label2.Visible = false;//密码不显示
                txtname.Visible = false;//用户名后面的文本框不显示
                txtpwd.Visible = false;//密码后的文本框不显示
                btnLogin.Visible = false;//登陆不显示
                btnRest.Visible = false;//重置不现实
                btnwordwrap.Visible = true;//自动换行显示
                btnsave.Visible = true;//保存显示
                txtwords.Visible = true;//大文本框显示
            }
            else//登陆失败
            {
                MessageBox.Show("用户名或密码输入错误，请重新输入");
                txtname.Clear();
                txtpwd.Clear();
                txtname.Focus();//为控件设置焦点
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpwd.Clear();
            txtname.Focus();
        }

        private void btnwordwrap_Click(object sender, EventArgs e)
        {
            if (btnwordwrap.Text == "自动换行")
            {
                txtwords.WordWrap = true;
                btnwordwrap.Text = "取消自动换行";
            }
            else if (btnwordwrap.Text == "取消自动换行")
            {
                txtwords.WordWrap = false;
                btnwordwrap.Text = "自动换行";
              }      
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (FileStream fswrite = new FileStream(@"C:\Users\陈家乐\Desktop\2.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(txtwords.Text);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}