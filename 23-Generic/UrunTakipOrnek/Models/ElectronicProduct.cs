using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic.UrunTakipOrnek.Models
{
    class ElectronicProduct : Product
    {
        public ElectronicProduct(string name,int stock,int warrantyPerriod) : base(name,stock)
        {


        }
        public override decimal TaxPrice()
        {
            throw new NotImplementedException();
        }
    }
}
