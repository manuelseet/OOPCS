using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class PersonProp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 0 && value < 150)
                {
                    this.age = value;
                }
            }
        }

        private float height;
        public float Height
        {
            get { return height; }
            set
            {
                if (value > 0.0 && value < 3.0)
                    height = value;
            }
        }

        public PersonProp(string firstname, string lastname, int age, float height)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Height = height;
        }

    }
}
