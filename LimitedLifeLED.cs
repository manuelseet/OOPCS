using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class LimitedLifeLED
    {
        private string color;
        private int maxLife = 20;
        private bool isOn = false;

        public LimitedLifeLED(string color, int maxlife)
        {
            this.color = color;
            if (maxlife > 0 && maxlife < 20)
                this.maxLife = maxlife;
        }

        public void turnOn()
        {
            if (maxLife > 0)
                isOn = true;
        }

        public void turnOff()
        {
            isOn = false;
            maxLife--;
        }

        public string getColor()
        {
            if (isOn == true)
                return this.color;
            else
                return null;
        }
    }
}
