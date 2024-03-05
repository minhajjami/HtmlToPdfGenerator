
using HtmlToPdfGenerator;
using HtmlToPdfGenerator.DataSource;

var invoice = InvoiceData.GetInvoices();
var html = HtmlStrings.GetInvoiceHtmlString(invoice);
InvoicePdfGenerator.GenerateInvoice(html);
