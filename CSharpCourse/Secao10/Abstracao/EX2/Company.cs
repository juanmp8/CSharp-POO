using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.Abstracao.EX2 {
    internal class Company : TaxPayer {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome) { 
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (NumberOfEmployees > 10) {
                return AnnualIncome * 0.14;
            } else {
                return AnnualIncome * 0.16;
            }
        }
    }
}
