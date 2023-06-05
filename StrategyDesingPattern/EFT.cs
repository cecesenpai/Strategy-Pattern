using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesingPattern
{
    public class EFT : Strategy
    {
        public EFT()
        {
        }

        public void MakePayment()
        {
            Console.WriteLine("EFT YÖNTEMİ İLE 5000TL ÖDEME YAPILDI.");
        }
    }
}
