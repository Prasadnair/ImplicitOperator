// See https://aka.ms/new-console-template for more information
using ImplcitOperatorTutorial;

Console.WriteLine("Implict Operator Example");
ContractEmployee contractEmployee = new ContractEmployee("Michael Joe", 25); // Hourly rate: $25

PermanentEmployee permanentEmployee = contractEmployee; // Implicit conversion happens here

Console.WriteLine(permanentEmployee.Name); // Output: Michael Joe
Console.WriteLine(permanentEmployee.MonthlySalary); // Output: 4000 (25 * 160)
Console.ReadLine();
