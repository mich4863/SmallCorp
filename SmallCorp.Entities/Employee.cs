using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCorp.Entities
{
    public class Employee : Person
    {
        private string position;
        private decimal salary;
        private DateTime startDate;

        public Employee(int id, string firstname, string lastname, string position, decimal salary, DateTime startDate) 
            : base(firstname, lastname)
        {
            Position = position;
            Salary = salary;
            StartDate = startDate;
        }

        public Employee(string firstname, string lastname, string position, decimal salary, DateTime startDate) 
            : this(id: default, firstname, lastname, position, salary, startDate) { }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public override string ToString()
        {
            return $"NAME: {Firstname} {Lastname} \nPOSITION: {Position} \nSALARY: {Salary:C} \nSTARTDATE: {StartDate.ToShortDateString()}\n\n";
        }
    }
}
