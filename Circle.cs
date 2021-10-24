using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Circle: Shape 
    {
        public Circle(string color, int radius): base (color)
        {

        }

        private int radius;

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
