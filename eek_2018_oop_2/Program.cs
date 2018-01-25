using System;

namespace eek_2018_oop_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person Tom = new Person('M', "Tom", 1987);
            Tom.PrintMe();
            Console.WriteLine();
            int age = Tom.CalculateAge();
            Console.WriteLine("The age of Tom: {0}", age);


            Person PasserBy = new Person('F');
            PasserBy.PrintMe();

            /*
                Workers section
            */

            Console.WriteLine();

            Worker Boss = new Worker('M', "Rocket Jesus", 1987, "Space", 1911, "CEO");
            Boss.PrintMe();

            Console.WriteLine();
            double taxFree = 500;
            double incomeTax = 20;

            double bossPay = Boss.CalculateNetPay(taxFree, incomeTax);

            Console.WriteLine("Boss pay: {0}", bossPay);

            /*
                Setting properties
            */
            Console.WriteLine();

            Worker NotBossAnymore = new Worker(Boss);

            NotBossAnymore.SaveJob("Janitor Emporium Inc");
            NotBossAnymore.pay = 1000;
            NotBossAnymore.Position = "Regular Joe";

            NotBossAnymore.PrintMe();

            Console.WriteLine();

            /*
                Calculate pay
            */
            double socialSecurityTax = 33;
            NotBossAnymore.CalculatePayRoll(socialSecurityTax);

            Console.Read();
        }
    }
}
