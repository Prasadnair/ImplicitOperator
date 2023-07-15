using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplcitOperatorTutorial
{
    internal class PermanentEmployee
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }

        public PermanentEmployee(string name, decimal monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }
        /// <summary>
        /// Implicit Conversion
        /// </summary>
        /// <param name="contractEmployee"></param>
        public static implicit operator PermanentEmployee(ContractEmployee contractEmployee)
        {
            // Convert ContractEmployee to PermanentEmployee
            decimal monthlySalary = contractEmployee.HourlyRate * 160; // Assuming 160 working hours in a month
            return new PermanentEmployee(contractEmployee.Name, monthlySalary);
        }
    }
}
