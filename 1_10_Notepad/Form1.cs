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
            btnwordwrap.Visible = false;//�Զ����в���ʾ
            btnsave.Visible = false;//���治��ʾ
            txtwords.WordWrap = false;//���ı�����ʾ
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtname.Text.Trim();
            string userpwd = txtpwd.Text;
            if (userName == "�¼���" && userpwd == "123456")
            {
                MessageBox.Show("��½�ɹ�");
                label1.Visible = false;//�û�������ʾ
                label2.Visible = false;//���벻��ʾ
                txtname.Visible = false;//�û���������ı�����ʾ
                txtpwd.Visible = false;//�������ı�����ʾ
                btnLogin.Visible = false;//��½����ʾ
                btnRest.Visible = false;//���ò���ʵ
                btnwordwrap.Visible = true;//�Զ�������ʾ
                btnsave.Visible = true;//������ʾ
                txtwords.Visible = true;//���ı�����ʾ
            }
            else//��½ʧ��
            {
                MessageBox.Show("�û��������������������������");
                txtname.Clear();
                txtpwd.Clear();
                txtname.Focus();//Ϊ�ؼ����ý���
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
            if (btnwordwrap.Text == "�Զ�����")
            {
                txtwords.WordWrap = true;
                btnwordwrap.Text = "ȡ���Զ�����";
            }
            else if (btnwordwrap.Text == "ȡ���Զ�����")
            {
                txtwords.WordWrap = false;
                btnwordwrap.Text = "�Զ�����";
              }      
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (FileStream fswrite = new FileStream(@"C:\Users\�¼���\Desktop\2.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(txtwords.Text);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("����ɹ�");
        }
    }
}