using ClosedXML.Excel;
using Kata_Invoicing.InvoiceManager.InvoiceExport;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            //string excelFilePath = @"ruta\al\archivo\tu_archivo.xlsx";
            string pdfFilePath = @"C:\Work\Data\SmartFinanceExport\PDFExample.pdf";


            InvoiceGenerator settlementReportGenerator = new InvoiceGenerator(1);
            var exportResult1 = settlementReportGenerator.ExportInvoiceXls();
            Console.WriteLine($"File {exportResult1.FilePath} exported");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(3);
            var exportResult2 = invoiceGenerator.ExportInvoiceXls();
            Console.WriteLine($"File {exportResult2.FilePath} exported");

            //Converting Excel to PDF
            invoiceGenerator = new InvoiceGenerator(4);
            invoiceGenerator.ConvertExcelToPdf(exportResult1.FilePath, pdfFilePath);

            Console.WriteLine("finished...");
            Console.ReadKey();

      
        }
    }
}
