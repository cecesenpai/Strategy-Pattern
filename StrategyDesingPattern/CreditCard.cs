using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesingPattern
{
    public class CreditCard : Strategy
    {
        public CreditCard()
        {

        }
        public void MakePayment()
        {
            Console.WriteLine("KREDİ KARTI YÖNTEMİ İLE 5000TL ÖDEME YAPILDI.");
        }
    }
}
