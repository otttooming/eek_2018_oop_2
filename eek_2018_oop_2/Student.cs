﻿using System;
namespace eek_2018_oop_2
{
    class Student : Person
    {
        protected string course;
        public int year { get; set; }
        protected string university;

        /*
            Change course by NOT using {get; set;} method
        */
        public void ChangeCourse(string newCourse) {
            this.course = newCourse;
        }

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
            Console.Write(" {0,-12} {1,7} {2,-12}", course, year, university);
        }
    }
}
