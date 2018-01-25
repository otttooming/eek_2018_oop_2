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

            Console.Read();
        }
    }
}
