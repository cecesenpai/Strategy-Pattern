using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesingPattern
{
    public class Cash : Strategy
    {
        public Cash()
        {

        }
        public void MakePayment()
        {
            Console.WriteLine("NAKİT YÖNTEMİ İLE 5000TL ÖDEME YAPILDI.");
        }
    }
}
