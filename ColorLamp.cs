using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    public class ColorLamp
    {
        private LED red;
        private LED green;
        private LED blue;
        private int counter = -1;

        public ColorLamp(LED red, LED blue, LED green)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void turnOff()
        {
            this.red.turnOff();
            this.green.turnOff();
            this.blue.turnOff();
        }

        public void turnOn()
        {
            counter++;
            switch(counter%3)
            {
                case 0:
                    this.red.turnOn(); break;
                case 1:
                    this.blue.turnOn(); break;
                case 2:
                    this.green.turnOn(); break;
            }
        }

        public string getCurrColor()
        {
            switch (counter % 3)
            {
                case 0:
                    return this.red.getColor(); break;
                case 1:
                    return this.blue.getColor(); break;
                default:
                    return this.green.getColor(); break;
            }
        }
    }
}
