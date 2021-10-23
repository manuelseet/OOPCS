using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    public class Stats
    {
        private int[] nums;
        private int len;

        public Stats(int[] nums)
        {
            this.nums = nums;
            this.len = nums.Length;
        }

        public double Mean()
        {
            double sum = 0;
            foreach (int i in nums)
                sum += i;
            double mean = sum / nums.Length;
            return mean;
        }

        public int Max()
        {
            return nums.Max();
        }

        public int Min()
        {
            return nums.Min();
        }

        public double SD(bool sample)
        {
            double SD = 0;
            double SS = 0;
            foreach (int i in nums)
            {
                SS += Math.Pow(i - this.Mean(), 2);
            }


            if (sample)
            {
                SD = Math.Sqrt(SS / len - 1);
                return SD;
            }

            else
            {
                SD = Math.Sqrt(SS / len);
                return SD;
            }
        }
    }
}
