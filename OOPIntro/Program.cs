using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation
            Person privatePerson = new Person("Ian", Sex.Male, 24);
            Console.WriteLine(privatePerson.name);
            //Console.WriteLine(privatePerson._age);
            Console.ReadKey();
            Console.Clear();
            // Inheritance
            Person person = new Person("Ian", Sex.Male, 24);

            person.Action();

            Person programmer = new Programmer("Ian", Sex.Male, 24);

            programmer.Action();

            Person teacher = new Teacher("Ian", Sex.Male, 24);

            teacher.Action();

            Console.ReadKey();
            Console.Clear();
            // Polymorphism
            Teacher teacher2 = new Teacher("Ian", Sex.Male, 24);
            // Teaching Math
            Console.WriteLine(teacher2.Teach(1,2));
            // Teaching English
            Console.WriteLine(teacher2.Teach("English"));

            Console.ReadKey();
        }
    }
}
