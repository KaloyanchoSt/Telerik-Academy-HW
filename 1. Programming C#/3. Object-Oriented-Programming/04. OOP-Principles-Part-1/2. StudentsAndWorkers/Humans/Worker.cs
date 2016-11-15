namespace StudentsAndWorkers.Humans
{
    using System;
    public class Worker : Human
    {
        private const int MaxWorkHours = 24;
        private const int MinWorkHours = 0;
        private const int WorkDaysInOneWeek = 5;

        public decimal weekSalary;
        public int workHoursPerDay;

        // Constructors
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //Prperties
        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative number");
                }

                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }

            private set
            {
                if (value < MinWorkHours || value > MaxWorkHours)
                {
                    throw new ArgumentOutOfRangeException("Working hours cannot be less than zero or more than 24 hours!");
                }

                this.workHoursPerDay = value;
            }
        }

        // Methods
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = ((this.WeekSalary / WorkDaysInOneWeek) / this.WorkHoursPerDay);

            return moneyPerHour;
        }
    }
}
