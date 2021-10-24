using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Rectangle: Shape
    {
        private int width;
        private int height;

        public Rectangle(string color, int width, int height): base (color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return (width * height);
        }

    }
}
