using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEjercices
{
    internal class SavingAccount:IAccount
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.3;
        }

        internal void CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }
}
