
using HtmlToPdfGenerator;

var html = HtmlStrings.GetInvoiceHtmlString();
InvoicePdfGenerator.GenerateInvoice(html);
