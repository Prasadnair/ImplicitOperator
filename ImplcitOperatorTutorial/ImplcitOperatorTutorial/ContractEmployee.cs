using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplcitOperatorTutorial
{
    internal class ContractEmployee
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }

        public ContractEmployee(string name, decimal hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }
    }
}
