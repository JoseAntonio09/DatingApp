using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata_Invoicing.Infrastructure;
using Kata_Invoicing.Infrastructure.RepositoryFramework;
using Kata_Invoicing.Model.IInvoices;

namespace Kata_Invoicing.Model.Invoices
{
    public static class InvoiceService
    {
        #region Private Fields
        private static IInvoiceRepository repository;
        private static IUnitOfWork unitOfWork;

        #endregion

        static InvoiceService()
        {
            InvoiceService.unitOfWork = new UnitOfWork();
            InvoiceService.repository = RepositoryFactory.GetRepository<IInvoiceRepository, Invoice>(InvoiceService.unitOfWork);

        }
        
        //Invoice
        public static Invoice GetInvoiceByID(int invoiceID)
        {
            return repository.FindBy(invoiceID);
        }

        public static bool UpdateInvoice(Invoice item)
        {
            repository[item.Key] = item;
            return unitOfWork.Commit();
        }

        public static List<InvoicePayment> GetInvoicePayments(int invoiceID)
        {
            return repository.GetInvoicePayments(invoiceID);
        }
        
        public static List<InvoiceFee> GetInvoiceFees(int invoiceID)
        {
            return repository.GetInvoiceFees(invoiceID);
        }
 
        public static InvoiceDetails GetInvoiceDetails(int invoiceID)
        {
            return repository.GetInvoiceDetails(invoiceID);
        }

        public static List<SettlementInvoice> GetSettlementInvoices(int invoiceID)
        {
            return repository.GetSettlementInvoices(invoiceID);
        }

        public static List<Refund> GetRefunds(int invoiceID)
        {
            return repository.GetRefunds(invoiceID);
        }

        public static List<RefundFee> GetRefundFees(int invoiceID)
        { 
            return repository.GetRefundFees(invoiceID);
        }
    }
}
