using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Triangle: Shape
    {
        private int width;
        private int height;

        public Triangle (string color, int width, int height): base (color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return (0.5 * width * height);
        }
    }
}
