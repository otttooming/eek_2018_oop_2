using System;
namespace eek_2018_oop_2
{
    class Student : Person
    {
        protected string course;
        public int Year { get; set; }
        protected string university;
        public double Stipendium { get; set; }

        /*
            Change course by NOT using {get; set;} method
        */
        public void ChangeCourse(string newCourse) {
            this.course = newCourse;
        }

        public Student(char gender = 'x', string name = "---", int dateOfBirth = 0,
                      string course = "---", int year = 0, string university = "---", double stipendium = 0)
            :base(gender, name, dateOfBirth)
        {
            this.course = course;
            this.Year = year;
            this.university = university;
            this.Stipendium = stipendium;
        }

        public Student(Student ob)
            :base(ob)
        {
            this.course = ob.course;
            this.Year = ob.Year;
            this.university = ob.university;
            this.Stipendium = ob.Stipendium;
        }

        public override void PrintMe()
        {
            base.PrintMe();
            Console.Write(" {0,-12} {1,7} {2,-12} {3,7:f2}", course, Year, university, Stipendium);
        }

        public override double CalculateIncome(double taxFree, double incomeTax) {
            return Stipendium;
        }
    }
}
