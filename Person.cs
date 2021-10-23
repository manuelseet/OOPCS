using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private float height;

        public Person(string firstName, string lastName, int age, float height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
        }

        public void sayHi()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }

        public void sayAge()
        {
            Console.WriteLine($"I am {age} years old");
        }

        public void sayHeight()
        {
            Console.WriteLine($"I am {height} m tall");
        }
    }
}
