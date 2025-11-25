using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace EmployeeHeritage.Classes
{
    
        public class Commercial : Employee
        {
            public double Turnover { get; set; }
            public double CommissionPct { get; set; }

            public Commercial() { }

            public Commercial(int id, string name, string service, string category, int salary,
                              double turnover, double commissionPct)
                : base(id, name, service, category, salary)
            {
                Turnover = turnover;
                CommissionPct = commissionPct;
            }

            public override double DisplaySalary()
            {
                double commission = Turnover * CommissionPct / 100;
                return Salary + commission;
            }

            public override string ToString()
            {
                return $"[Commercial] ID:{Id} | {Name} | Turnover:{Turnover} € | " +
                       $"%Com:{CommissionPct}% | Salaire total:{DisplaySalary()} €";
            }
        

    }
}
