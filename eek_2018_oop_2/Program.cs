using System;
using System.Collections;
using System.Collections.Generic;

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

            /*
                Create student
            */
            Console.WriteLine();

            Student Geek = new Student('M', "Jhonny Appleseed", 1992, "History", 2017, "Caltec", 345);

            Geek.PrintMe();

            Console.WriteLine();

            Geek.Year = 2018;

            Geek.ChangeCourse("Media");
            Geek.PrintMe();

            /*
                Polymorphism
            */

            Worker JaneWorker = new Worker('F', "Jane Smith", 1987, "Train conductor", 1911, "Operator");
            Student SamStudent = new Student('F', "Samantha Sam", 1992, "History", 2017, "MIT", 345);

            List<Person> Hikers = new List<Person>();
            Hikers.Add(JaneWorker);
            Hikers.Add(SamStudent);
            Hikers.Add(Boss);
            Hikers.Add(NotBossAnymore);
            Hikers.Add(PasserBy);
            Hikers.Add(Tom);
            Hikers.Insert(2, new Student('F', "Rita Doe", 1987, "History", 2001, "Virginia State", 3245));


            Console.WriteLine("\nLoop\n");

            foreach(Person x in Hikers)
            {
                x.PrintMe();  
                Console.WriteLine();
                double income = x.CalculateIncome(taxFree, incomeTax);
                Console.WriteLine("Income is: {0}", income);
            }

            /*
                Calculate hiking workers average income
            */
            double sumWorkerIncome = 0;
            int numberOfWorkers = 0;
            foreach(Person x in Hikers)
            {
                if (x is Worker)
                {
                    x.PrintMe();
                    Console.WriteLine();
                    double income = x.CalculateIncome(taxFree, incomeTax);
                    sumWorkerIncome = sumWorkerIncome + income;
                    numberOfWorkers++;
                }
            }

            Console.WriteLine("Worker average pay is: {0}", sumWorkerIncome / numberOfWorkers);

            Console.Read();
        }
    }
}
