using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    public class Programmer : Person
    {
        public Programmer(String name, Sex sex, int age):base(name, sex, age){}

        public override void Action()
        {
            Console.WriteLine("I Program");
        }
    }
}
