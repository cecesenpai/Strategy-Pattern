using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new EFT());
            context.MakePayment();

            var context2 = new Context(new CreditCard());
            context2.MakePayment();

            var context3 = new Context(new Cash());
            context3.MakePayment();


            Console.ReadLine();
        }
    }
}
