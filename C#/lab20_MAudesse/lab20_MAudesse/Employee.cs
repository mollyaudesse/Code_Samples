using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_MAudesse
{
    class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;

            }

            set
            {
                name = value;
            }
        }

        private decimal salary;
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

        public Employee(string n, decimal s)
        {
            Name = n; Salary = s;
        }

    }
}