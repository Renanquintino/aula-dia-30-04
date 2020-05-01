using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula3004.Entities
{
    class ImportedProduct : Product
    {
        public double CustomesFee { get; set; }
        public ImportedProduct(string name, double price, double customesFee)
            : base(name, price)
        {
            CustomesFee = customesFee;
        }
        public double Total()
        {
           
            return (Price+CustomesFee);
        }


        public override string PriceTag()
        {
            return Name
                +" $"
               + Total().ToString("F2", CultureInfo.InvariantCulture)
                + "( Customes Fee: "
                
                + CustomesFee.ToString("F2",CultureInfo.InvariantCulture)
                + ")";

           
        }

    }
}
