using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa1 = new SavingsAccount("Diego");

            SavingsAccount.baseInterestRate = 1.00f;

            SavingsAccount sa2 = new SavingsAccount("Manny");

            sa1.printIR();
            sa2.printIR();
        }

        public class SavingsAccount
        {
            public static double baseInterestRate = 0.05;

            public string Name { get; set; }

            public SavingsAccount(string Name)
            {
                this.Name = Name;
            }
            
            public void printIR()
            {
                Console.WriteLine($"{baseInterestRate}");
            }
        }
    }
}
