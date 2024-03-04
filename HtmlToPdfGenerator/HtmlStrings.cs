namespace HtmlToPdfGenerator
{
    public static class HtmlStrings
    {       
        public static string GetInvoiceHtmlString()
        {
            var logo = Path.Combine(Directory.GetCurrentDirectory(), "Images", "logo.png");

            string html = $@"<!DOCTYPE html>
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
                            <body>
                                <div class=""container"">
                                    <div class=""header"">
                                        <img src='{logo}' alt=""Company Logo"" class=""logo"">
                                    </div>

                                    <div class=""customer-info"">
                                        <h3>Customer Information</h3>
                                        <p><strong>Customer Name:</strong> John Doe</p>
                                        <p><strong>Address:</strong> 123 Main Street, City, Country</p>
                                        <p><strong>Email:</strong> john@example.com</p>
                                        <p><strong>Phone:</strong> +1234567890</p>
                                    </div>

                                    <div class=""billing-info"">
                                        <h3>Billing Information</h3>
                                        <p><strong>Invoice Number:</strong> INV-123456</p>
                                        <p><strong>Issue Date:</strong> March 4, 2024</p>
                                        <p><strong>Due Date:</strong> March 31, 2024</p>
                                        <!-- You can add more billing information here -->
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
                                        <tbody>
                                            <tr>
                                                <td>Item 1</td>
                                                <td>Description of Item 1</td>
                                                <td>2</td>
                                                <td>$10</td>
                                                <td>$20</td>
                                            </tr>
                                            <tr>
                                                <td>Item 2</td>
                                                <td>Description of Item 2</td>
                                                <td>1</td>
                                                <td>$15</td>
                                                <td>$15</td>
                                            </tr>
                                            <tr>
                                                <td>Item 3</td>
                                                <td>Description of Item 3</td>
                                                <td>3</td>
                                                <td>$8</td>
                                                <td>$24</td>
                                            </tr>
                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <td colspan=""4"" style=""text-align: right;"">Subtotal</td>
                                                <td>$59</td>
                                            </tr>
                                            <tr>
                                                <td colspan=""4"" style=""text-align: right;"">Tax (10%)</td>
                                                <td>$5.9</td>
                                            </tr>
                                            <tr>
                                                <td colspan=""4"" style=""text-align: right;"">Total</td>
                                                <td>$64.9</td>
                                            </tr>
                                        </tfoot>
                                    </table>
                                </div>
                            </body>
                            </html>";

            return html;
        }
    }
}
