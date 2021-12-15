
using System;

namespace FunctionalProgramming
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }
         
        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return
                    string.Format($"" +
                    $"{Id}\t" +
                    $" {String.Concat(LastName, ", ", FirstName).PadRight(15, ' ')}\t" + 
                    $"{HireDate.Date.ToShortDateString()}\t" +
                    $"{Gender.PadRight(10, ' ')}\t" +
                    $"{Department.PadRight(10, ' ')}\t" +
                    $"{HasHealthInsurance}\t" +
                    $"{HasPensionPlan}\t" +
                    $"${Salary.ToString("0.00")}");
        }
    }

    
}
