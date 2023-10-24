using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpCourse.Secao10.HerancaPolimorfismo.EX2
{
    internal class UsedProduct : Product
    {
        public string Date { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, string date) : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name + " (used)" + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $" (Manufacture date: {Date})";
        }
    }
}
