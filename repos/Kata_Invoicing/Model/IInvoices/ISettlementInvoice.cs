using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.IInvoices
{
    public interface ISettlementInvoice
    {
        string InvoiceId { get; }
        DateTime InvoiceDate { get; }
        decimal TotalAmount { get; }
        IReadOnlyList<IRefund> Refunds { get; }

        void AddRefund(IRefund refund);
        decimal GetNetAmount();
    }
}
