using Kata_Invoicing.Model.IInvoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.Invoices
{
    public class SettlementInvoice: ISettlementInvoice
    {
        public string InvoiceId { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public IReadOnlyList<IRefund> Refunds => _refunds.AsReadOnly();
        private readonly List<IRefund> _refunds = new List<IRefund>();

        public SettlementInvoice(string invoiceId, DateTime invoiceDate, decimal totalAmount)
        {
            InvoiceId = invoiceId;
            InvoiceDate = invoiceDate;
            TotalAmount = totalAmount;
        }

        public void AddRefund(IRefund refund)
        {
            _refunds.Add(refund);
        }

        public decimal GetNetAmount()
        {
            return TotalAmount - _refunds.Sum(r => r.GetNetRefundAmount());
        }


    }
}
