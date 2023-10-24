namespace CSharpCourse.Secao10.Abstracao.EX2 {
    internal abstract class TaxPayer {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer(string name, double annualIncome) { 
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
