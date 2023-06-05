using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesingPattern
{
    public class Context
    {
        private Strategy odeme;
        public Context( Strategy _odeme)
        {
            odeme = _odeme;
        }
        public void MakePayment()
        {
            this.odeme.MakePayment();
        }
    }
}
