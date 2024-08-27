using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_Invoicing.Model.IInvoices;
using Kata_Invoicing.Model.Invoices;

namespace Kata_Invoicing.Infrastructure.Repositories.Invoices
{
    class InvoiceRepository : SqlRepositoryBase<Invoice>, IInvoiceRepository
    {
        protected override string GetEntityName()
        {
            return "Invoice";
        }

        protected override string GetKeyFieldName()
        {
            return InvoiceFactory.FieldNames.Id;
        }

        #region Public Constructors

        public InvoiceRepository()
            : this(null)
        {
        }

        public InvoiceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion

        #region UnitOfWorkImplementation
        protected override void BuildChildCallbacks()
        {

        }

        protected override SqlCommand AllEntitiesSqlCommand()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoiceGetAll";
            return command;
        }

        protected override SqlCommand EntityByKeySqlCommand(int key)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoiceGetByID";
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = (key);
            return command;
        }

        protected SqlCommand UpdateEntitySqlCommand(Invoice invoice)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoiceUpdate";

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = invoice.ID;
            

            command.Parameters.Add("@InvoiceFilePathXLS", SqlDbType.VarChar);
            command.Parameters["@InvoiceFilePathXLS"].Value = invoice.InvoiceFilePathXLS;

            return command;
        }
        
        protected override bool PersistNewItem(Invoice item)
        {
            return false;
        }

        protected override bool PersistUpdatedItem(Invoice item)
        {
            return PersistanceManager.PersistanceManager.ExecuteStoredProcedureNonQuery(UpdateEntitySqlCommand(item));
        }

        protected override bool PersistDeletedItem(Invoice item)
        {
            return false;
        }
        #endregion

        #region Public Methods


        public List<InvoicePayment> GetInvoicePayments(int invoiceID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoicePaymentsGetByInvoiceID";
            command.Parameters.Add(new SqlParameter("@InvoiceID", SqlDbType.Int));
            command.Parameters["@InvoiceID"].Value = invoiceID;

            return PersistanceManager.PersistanceManager.ExecuteStoredProcedureQuery<InvoicePayment>(command).ToList();
        }
  

        public List<InvoiceFee> GetInvoiceFees(int invoiceID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoiceFeesGetByInvoiceID";
            command.Parameters.Add(new SqlParameter("@InvoiceID", SqlDbType.Int));
            command.Parameters["@InvoiceID"].Value = invoiceID;

            return PersistanceManager.PersistanceManager.ExecuteStoredProcedureQuery<InvoiceFee>(command).ToList();
        }
     

        public InvoiceDetails GetInvoiceDetails(int invoiceID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InvoiceDetailsGetByInvoiceID";
            command.Parameters.Add(new SqlParameter("@InvoiceID", SqlDbType.Int));
            command.Parameters["@InvoiceID"].Value = invoiceID;

            return PersistanceManager.PersistanceManager.ExecuteStoredProcedureQuery<InvoiceDetails>(command).ToList().FirstOrDefault() ?? new InvoiceDetails();
        }
       
        private readonly List<SettlementInvoice> _invoices = new List<SettlementInvoice>();
        List<SettlementInvoice> IInvoiceRepository.GetSettlementInvoices(int invoiceID)
        {

            var invoice1 = new SettlementInvoice("INV001", DateTime.Now.AddDays(-10), 1000m);
            var invoice2 = new SettlementInvoice("INV002", DateTime.Now.AddDays(-5), 1500m);
            _invoices.Add(invoice1);
            _invoices.Add(invoice2);

           
            return _invoices;
        }

        private readonly List<Refund> _invoicesRefund = new List<Refund>();
        List<Refund> IInvoiceRepository.GetRefunds(int invoiceID)
        {
            var refund1 = new Refund("12345", 1000m);
            var refund2 = new Refund("12346", 1500m);
            _invoicesRefund.Add(refund1);
            _invoicesRefund.Add(refund2);

            return _invoicesRefund;
        }


        private readonly List<RefundFee> _invoicesRefundFee = new List<RefundFee>();
        List<RefundFee> IInvoiceRepository.GetRefundFees(int invoiceID)
        {
            var refundFee1 = new RefundFee("1", 0.02m);
            var refundFee2 = new RefundFee("2", 0.04m);
            _invoicesRefundFee.Add(refundFee1);
            _invoicesRefundFee.Add(refundFee2);

            return _invoicesRefundFee; 
        }

        #endregion
    }
}
