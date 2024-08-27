using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.IInvoices
{
    public interface IRefund
    {
        string RefundId { get; }
        decimal Amount { get; }
        IReadOnlyList<IRefundFee> Fees { get; }

        void AddFee(IRefundFee fee);
        decimal GetTotalFees();
        decimal GetNetRefundAmount();
    }
}
