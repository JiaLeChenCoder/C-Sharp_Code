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
            if (rdostudent.Checked || rdotecher.Checked)//ѡ�������ʦ����ѧ��
            {
                string name = txtname.Text.Trim();
                string pwd = txtpwd.Text;
                if (rdostudent.Checked)
                {
                    if (name == "student" && pwd == "123456")
                    {
                        MessageBox.Show("��½�ɹ�");
                    }
                    else
                    {
                        MessageBox.Show("��½ʧ��");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
                else//ѡ�������ʦ
                {
                    if (name == "teacher" && pwd == "123456")
                    {
                        MessageBox.Show("��ʦ��¼�ɹ�");
                    }
                    else
                    {
                        MessageBox.Show("��½ʧ��");
                        txtname.Clear();
                        txtpwd.Clear();
                        txtname.Focus();
                    }
                }
            }
            else//��ûѡ�� 
            {
                MessageBox.Show("��ѡ���½���");
            }
        }
    }
}