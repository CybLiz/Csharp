using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHeritage.Classes
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public string Category { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(int id, string name, string service, string category, int salary)
        {
            Id = id;
            Name = name;
            Service = service;
            Category = category;
            Salary = salary;
        }

        public virtual double DisplaySalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"[Employee] ID:{Id} | {Name} | Service:{Service} | Cat:{Category} | Salary:{DisplaySalary()} €";
        }
    }
}
