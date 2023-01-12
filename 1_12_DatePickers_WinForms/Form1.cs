using System.IO; 
namespace _1_12_DatePickers_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载时，将年份添加到下拉框中，获得当前的年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当年份改变时，加载月份
            //添加事件之前应清空之前的内容
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当月份改变时，加载天
            cboDays.Items.Clear();
            int day = 0;//定义一个变量，有天数
            string  strmonth = cboMonth.SelectedItem.ToString().Split(new char[] { '月' },StringSplitOptions.RemoveEmptyEntries)[0];//获得月份
            string stryear = cboYear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int year = Convert.ToInt32(stryear);
            int month = Convert.ToInt32(strmonth);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31; break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30; break;
            }
                    for (int i = 1; i <= day; i++)
                    {
                        cboDays.Items.Add(i + "日");
                    }
            
        }
    }
}