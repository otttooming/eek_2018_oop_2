using System;
namespace eek_2018_oop_2
{
    class Person : IFirstInterface
    {
        protected string name;
        protected int dateOfBirth;
        protected char gender;

        public Person(char gender = 'x', string name = "---", int dateOfBirth = 0)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        /*
            Constructor for cloning is not always needed
        */
        public Person(Person ob)
        {
            this.name = ob.name;
            this.dateOfBirth = ob.dateOfBirth;
            this.gender = ob.gender;
        }

        public void PrintMe()
        {
            Console.Write("{0,-12} {1} {2,4}", name, gender, dateOfBirth);
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth;

            return age;
        }
    }
}
