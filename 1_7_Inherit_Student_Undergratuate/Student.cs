using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Inherit_Student_Undergratuate
{
    internal class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _age;
        public double Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public Student(string _name, double _age)
        {
            this.Name = _name;
            this.Age = _age;
        }
        //public Student()
        //{ }
        public void Show()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了", this.Name, this.Age);
        }
    }
}
