namespace _1_9_StudentTeacherLogin_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdostudent.Checked || rdotecher.Checked)//选择的是老师或者学生
            {
                string name = txtname.Text.Trim();
                string pwd = txtpwd.Text;
                if (rdostudent.Checked)
                {
                    if (name == "student" && pwd == "123456")
                    {
                        MessageBox.Show("登陆成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
                else//选择的是老师
                {
                    if (name == "teacher" && pwd == "123456")
                    {
                        MessageBox.Show("老师登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
            }
            else//都没选中 
            {
                MessageBox.Show("请选择登陆身份");
            }
        }
    }
}