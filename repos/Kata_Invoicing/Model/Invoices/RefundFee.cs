using Kata_Invoicing.Model.IInvoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.Invoices
{
    public class RefundFee : IRefundFee
    {
        public string FeeType { get; private set; }
        public decimal Amount { get; private set; }

        public RefundFee(string feeType, decimal amount)
        {
            FeeType = feeType;
            Amount = amount;
        }
    }
}
