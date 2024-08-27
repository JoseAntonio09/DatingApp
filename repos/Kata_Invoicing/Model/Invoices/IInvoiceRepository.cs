using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_Invoicing.Infrastructure.RepositoryFramework;
using Kata_Invoicing.Model.IInvoices;

namespace Kata_Invoicing.Model.Invoices
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        List<InvoicePayment> GetInvoicePayments(int invoiceID);
        List<InvoiceFee> GetInvoiceFees(int invoiceID);
        InvoiceDetails GetInvoiceDetails(int invoiceID);

        //List<SettlementInvoice> GetSettlementInvoices(int invoiceID);
        //Task<IEnumerable<ISettlementInvoice>> GetSettlementInvoicesAsync(DateTime startDate, DateTime endDate);
        List<SettlementInvoice> GetSettlementInvoices(int invoiceID);
        List<Refund> GetRefunds(int invoiceID);
        List<RefundFee> GetRefundFees(int invoiceID);
    }
}

