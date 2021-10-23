using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    public class LED
    {
        private string color; 
        private bool isOn = false;


        public LED(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public bool isLEDOn()
        {
            return isOn;
        }

        public void turnOn()
        {
            isOn = true;
        }

        public void turnOff()
        {
            isOn = false;
        }
    }
}
