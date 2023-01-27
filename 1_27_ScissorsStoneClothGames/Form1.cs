using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_27_ScissorsStoneClothGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PlayGame(string str)
        {
            lblplayer.Text = str;
            player player = new player();
            int PlayerNumber = player.ShowFist(str);
            Computer Cpu = new Computer();
            int ComputerNumber = Cpu.ShowFist();
            lblcomputer.Text = Cpu.Fist;
            Result res = Referee.Judge(PlayerNumber, ComputerNumber);
            lblResult.Text = res.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
