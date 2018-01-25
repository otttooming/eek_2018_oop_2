using System;
namespace eek_2018_oop_2
{
    class Student : Person
    {
        public string course;
        public int year;
        public string university;

        public Student(char gender = 'x', string name = "---", int dateOfBirth = 0,
                      string course = "---", int year = 0, string university = "---")
            :base(gender, name, dateOfBirth)
        {
            this.course = course;
            this.year = year;
            this.university = university;
        }

        public Student(Student ob)
            :base(ob)
        {
            this.course = ob.course;
            this.year = ob.year;
            this.university = ob.university;
        }

        public override void PrintMe()
        {
            base.PrintMe();
            Console.Write("{0,-12} {1,7:f2} {2,-12}", course, year, university);
        }
    }
}
