
namespace _02.StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastname)
            : base(firstName, lastname)
        {

        }
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours cannot be negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double result = (this.weekSalary / 5.0) / this.workHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, Week Salary: {2}, WorkHoursPerDay: {3} ",
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
