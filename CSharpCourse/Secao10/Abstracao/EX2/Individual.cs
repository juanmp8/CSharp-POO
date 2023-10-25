using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.Abstracao.EX2
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (HealthExpenditures > 0) {
                if (AnnualIncome < 2000.00) {
                    double tax = AnnualIncome * 0.15;
                    return tax - (HealthExpenditures * 0.5);
                } else {
                    double tax = AnnualIncome * 0.25;
                    return tax - (HealthExpenditures * 0.5);
                }
            } else {
                if (AnnualIncome < 2000.00) {
                    return AnnualIncome * 0.15;
                } else {
                    return AnnualIncome * 0.25;
                }
            }
        }
    }
}
