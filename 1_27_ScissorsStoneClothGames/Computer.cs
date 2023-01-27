using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _1_27_ScissorsStoneClothGames
{
    internal class Computer
    {
        public string Fist
        {
            get;
            set;
        }
        public int ShowFist()
        {
            Random r = new Random();
            int rnumber = r.Next(1, 4);
            switch (rnumber)
            {
                case 1:this.Fist = "石头";break;
                case 2: this.Fist = "剪刀"; break;
                case 3: this.Fist = "布"; break;
            }
            return rnumber; 
        }
    }
}
