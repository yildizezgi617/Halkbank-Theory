using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Struct
{
    public struct Currency
    {
        private bool isStarted;
        public Currency(decimal amount, string symbol,bool isstarted= true)
        {
            Amount = amount;
            Symbol = symbol;
            this.isStarted = isstarted;

        }

        public decimal Amount { get; set; }
        public string Symbol { get; set; }
        
        public string GetCurrency()
        {
            return isStarted ? $"{Symbol} {Amount}" : $"{Amount} {Symbol}";
        }
    
    
    
    }
}
