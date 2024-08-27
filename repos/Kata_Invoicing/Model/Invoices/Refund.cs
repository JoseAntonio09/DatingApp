using Kata_Invoicing.Model.IInvoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.Invoices
{
    public class Refund : IRefund
    {
        public string RefundId { get; private set; }
        public decimal Amount { get; private set; }
        public IReadOnlyList<IRefundFee> Fees => _fees.AsReadOnly();
        private readonly List<IRefundFee> _fees = new List<IRefundFee>();


        public Refund(string refundId, decimal amount)
        {
            RefundId = refundId;
            Amount = amount;
        }

        public void AddFee(IRefundFee fee)
        {
            _fees.Add(fee);
        }

        public decimal GetTotalFees()
        {
            return _fees.Sum(f => f.Amount);
        }

        public decimal GetNetRefundAmount()
        {
            return Amount - GetTotalFees();
        }

    }
}
