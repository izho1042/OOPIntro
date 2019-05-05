using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    public class Teacher:Person
    {
        public Teacher(String name, Sex sex, int age) : base(name, sex, age) { }

        public override void Action()
        {
            Console.WriteLine("I Teach");
        }

        public int Teach(int a, int b)
        {
            return a+b;
        }

        public String Teach(String a)
        {
            return a;
        }
    }
}
