using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class EvenNumber
    {
        private int num = 0; 

        public EvenNumber()
        {

        }

        public bool SetEvenNumber(int n)
        {
            if (this.IsEven(n) == true)
            {
                this.num = n;
                return true;
            }
            else
                return false;
        }

        public int GetValue()
        {
            return num;
        }

        public bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

    }
}
