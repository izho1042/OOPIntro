using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    public class Person // Class Name
    {
        // Member Variables
        public String name;
        public Sex sex;
        private int _age;

        // Constructor
        public Person(String name, Sex sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this._age = age;
        }

        // Member Method/Functions
        public virtual void Action()
        {
            Console.WriteLine("A Person Eats");
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }

    public enum Sex { Female, Male, Other };
}
