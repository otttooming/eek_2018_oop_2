﻿using System;
namespace eek_2018_oop_2
{
    class Worker : Person
    {
        protected string job;
        protected double pay;
        protected string position;

        public Worker(char gender = 'x', string name = "---", int dateOfBirth = 0,
                      string job = "---", double pay = 0, string position = "---")
            :base(gender, name, dateOfBirth)
        {
            this.job = job;
            this.pay = pay; // Referes to pay before taxes, GROSS WAGE
            this.position = position;

        }

        public Worker(Worker ob)
            :base(ob)
        {
            this.job = ob.job;
            this.pay = ob.pay;
            this.position = ob.position;
        }

        public override void PrintMe()
        {
            base.PrintMe();
            Console.Write(" {0,-12} {1,7:f2} {2,-12}", job, pay, position);
        }

        public double CalculateNetPay(double taxFree, double incomeTax)
        {
            /*
                Calculate pay without income tax and including tax free value
            */
            double subtracked = (pay - taxFree) * incomeTax / 100;

            return pay - subtracked;
        }
    }
}