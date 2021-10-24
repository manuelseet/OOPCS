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
            //Color lamp
            LED redLED = new LED("red");
            LED blueLED = new LED("blue");
            LED greenLED = new LED("green");

            ColorLamp lamp = new ColorLamp(redLED, blueLED, greenLED);

            for(int i = 0; i<10; i++)
            {
                lamp.turnOn();
                Console.WriteLine("Color: " + lamp.getCurrColor());
                lamp.turnOff();
            }

            //limited lifespan LED

            LimitedLifeLED llled = new LimitedLifeLED("purple", 23);

            for (int i = 0; i < 25; i++)
            {
                llled.turnOn();
                Console.WriteLine($"Turn {i+1} Color: " + llled.getColor());
                llled.turnOff();
            }

            // Person
            Person gary = new Person("gary", "tan", 24, 1.7f);
            Person jane = new Person("jane", "lee", 45, 1.4f);

            gary.sayHi();
            gary.sayAge();
           gary.sayHeight();

            Console.WriteLine();

            jane.sayHi();
            jane.sayAge();
            jane.sayHeight();

            //stats
            int[] data = new int[] { 10, 5, 8, 19, -3, 2, 14 };
            Stats stat = new Stats(data);

            Console.WriteLine(stat.Max());
            Console.WriteLine(stat.Min());
            Console.WriteLine(stat.Mean());
            Console.WriteLine(stat.SD(true));


            //EvenNumber
            int[] data1 = { 11, 9, 8, 2, 5, 12 };
            EvenNumber num = new EvenNumber();

            for (int i = 0; i < data1.Length; i++)
            {
                if (num.SetEvenNumber(data1[i]))
                {
                    Console.WriteLine("Updated Succeeded");
                    //Console.WriteLine("Value is now " + num.GetValue() + ".");
                }
                else
                {
                    Console.WriteLine("Updated failed");
                    Console.WriteLine(data[i] + " is not Even.");
                }
                Console.WriteLine("");
            }


            //PersonProp
            PersonProp mike = new PersonProp("mike", "tan", 15, 1.2f);
            Console.WriteLine($"{mike.FirstName} {mike.LastName} {mike.Age} {mike.Height}");

            //
            int width = 5;
            int height = 10;
            int radius = 2;

            Shape rectangle = new Rectangle("green", width, height);
            Console.WriteLine("Area of Rectangle is {0}", rectangle.Area());
            Console.WriteLine("The color of Rectangle is {0}", rectangle.GetColor());

            Shape triangle = new Triangle("red", width, height);
            Console.WriteLine("Area of Triangle = " + triangle.Area());

            Shape circle = new Circle("purple", radius);
            Console.WriteLine("Area of Circle = {0: #.00}", circle.Area());

            //Interface
            List<ISyncable> syncables = new List<ISyncable>();

            syncables.Add(new Email("Hi", "jane@gmail.com", "Free for Lunch?"));
            syncables.Add(new Event("Lunch with Jane", new DateTime(2021, 9, 15, 19, 0, 0)));

            string serializedSync = "";
            foreach (ISyncable item in syncables) //the datatype for item can be Item or ISyncable, all ok
            {
                serializedSync += item.GetSyncString();
            }

            Console.WriteLine(serializedSync);

            //Bonus
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
