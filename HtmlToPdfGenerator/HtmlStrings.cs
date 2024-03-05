using HtmlToPdfGenerator.Models;
using System.Text;

namespace HtmlToPdfGenerator
{
    public static class HtmlStrings
    {
        public static string GetInvoiceHtmlString(List<Invoice> invoices)
        {
            var logo = Path.Combine(Directory.GetCurrentDirectory(), "Images", "logo.png");

            StringBuilder html = new StringBuilder();

             html.Append( $@"<!DOCTYPE html>
                            <html lang=""en"">
                            <head>
                                <meta charset=""UTF-8"">
                                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                <title>Invoice</title>
                                <style>
                                    body {{
                                        font-family: Arial, sans-serif;
                                        margin: 0;
                                        padding: 0;
                                    }}
                                    .container {{
                                        max-width: 800px;
                                        margin: 0 auto;
                                        padding: 20px;
                                    }}
                                    .header {{
                                        display: flex;
                                        justify-content: space-between;
                                        align-items: center;
                                        margin-bottom: 20px;
                                    }}
                                    .logo {{
                                        width: 100px;
                                        float: right;
                                    }}
                                    table {{
                                        width: 100%;
                                        border-collapse: collapse;
                                        margin-top: 20px;
                                    }}
                                    th, td {{
                                        border: 1px solid #ddd;
                                        padding: 8px;
                                        text-align: left;
                                    }}
                                    th {{
                                        background-color: #f2f2f2;
                                    }}
                                    .customer-info {{
                                        margin-top: 20px;
                                    }}
                                    .billing-info {{
                                        margin-top: 20px;

                                    }}
                                    @media only screen and (max-width: 600px) {{
                                        table {{
                                            font-size: 12px;
                                        }}
                                        .logo {{
                                            width: 300px;
                                        }}
                                    }}
                                </style>
                            </head>
                            <body>");

            foreach (var invoice in invoices)
            {
                html.Append($@"<div class=""container"">
                                <div class=""header"">
                                    <img src='{logo}' alt=""Company Logo"" class=""logo"">
                                </div>
                                
                                <div class=""customer-info"">
                                    <h3>Customer Information</h3>
                                    <p><strong>Customer Name:</strong> {invoice.Customer.Name}</p>
                                    <p><strong>Address:</strong> {invoice.Customer.Address}</p>
                                    <p><strong>Email:</strong> {invoice.Customer.Email}</p>
                                    <p><strong>Phone:</strong> {invoice.Customer.Phone}</p>
                                </div>

                                <div class=""billing-info"">
                                    <h3>Billing Information</h3>
                                    <p><strong>Invoice Number:</strong> {invoice.InvoiceNo}</p>
                                    <p><strong>Issue Date:</strong> {invoice.DueDate.ToString("dddd, dd MMMM yyyy")}</p>
                                    <p><strong>Due Date:</strong> {invoice.IssueDate.ToString("dddd, dd MMMM yyyy")}</p>
                                </div>

                                <table>
                                    <thead>
                                        <tr>
                                            <th>Item</th>
                                            <th>Description</th>
                                            <th>Quantity</th>
                                            <th>Unit Price</th>
                                            <th>Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>");

                foreach (var item in invoice.Items)
                {
                    html.Append($@"<tr>
                                    <td>{item.Item}</td>
                                    <td>{item.Description}</td>
                                    <td>{item.Quantity}</td>
                                    <td>${item.UnitPrice}</td>
                                    <td>${item.Quantity * item.UnitPrice}</td>
                                </tr>");
                }

                html.Append($@"</tbody>
                            <tfoot>
                                <tr>
                                    <td colspan=""4"" style=""text-align: right;"">Subtotal</td>
                                    <td>${invoice.Items.Sum(x => x.Quantity * x.UnitPrice)}</td>
                                </tr>
                                <tr>
                                    <td colspan=""4"" style=""text-align: right;"">Tax (10%)</td>
                                    <td>${invoice.Items.Sum(x => x.Quantity * x.UnitPrice)}</td>
                                </tr>
                                <tr>
                                    <td colspan=""4"" style=""text-align: right;"">Total</td>
                                    <td>${invoice.Items.Sum(x => x.Quantity * x.UnitPrice)}</td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>");
            }

            html.Append(@"</body>
                    </html>");

            return html.ToString();
        }
    }
}
