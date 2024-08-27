using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Invoicing.Model.IInvoices
{
    public interface ISettlementInvoiceRepository
    {
        Task<IEnumerable<ISettlementInvoice>> GetSettlementInvoicesAsync(DateTime startDate, DateTime endDate);
    }
}
