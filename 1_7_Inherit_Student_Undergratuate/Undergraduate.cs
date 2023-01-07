using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Inherit_Student_Undergratuate
{
    internal class Undergraduate:Student
    {
        private string _degree;
        public string Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }
        public Undergraduate(string _name, double _age, string _degree) : base(_name, _age)
        {
            this.Degree = _degree;

        }
        public void Show()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我的学历是{2}", this.Name, this.Age, this.Degree);
        }
    }
}
