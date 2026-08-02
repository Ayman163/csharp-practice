using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John Doe";
            employee.BaseSalary = 50000;
            Console.WriteLine($"Employee: {employee.Name}, Salary: ${employee.CalculateSalary():F2}");

            Developer developer = new Developer();
            developer.Name = "Jane Smith";
            developer.BaseSalary = 60000;
            developer.Bonus = 10000;
            Console.WriteLine($"Developer: {developer.Name}, Salary: ${developer.CalculateSalary():F2}");

            Manager manager = new Manager();
            manager.Name = "Alice Johnson";
            manager.BaseSalary = 80000;
            manager.Allowance = 15000;
            Console.WriteLine($"Manager: {manager.Name}, Salary: ${manager.CalculateSalary():F2}");
        }   
    }
    public class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
    }
    

    public class Developer : Employee
    {
        public decimal Bonus { get; set; }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + Bonus;
        }
    }

    public class Manager : Employee
    {
        public decimal Allowance { get; set; }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + Allowance;
        }
    }
}
