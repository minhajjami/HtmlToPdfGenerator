using HtmlToPdfGenerator.Models;

namespace HtmlToPdfGenerator.DataSource
{
    public static class InvoiceData
    {
        public static List<Invoice> GetInvoices()
        {
            return new List<Invoice>()
            {
                new Invoice()
                {
                    Id = 1,
                    InvoiceNo = "Inv-123456",
                    IssueDate = new DateTime(2024,03,4),
                    DueDate = new DateTime(2024,03,31),
                    Customer = new Customer()
                    {
                        Id = 1,
                        Name = "Minhaj Jami",
                        Address ="8 Mohakhali,Dhaka",
                        Email ="minhaj@gmail.com",
                        Phone = "+018000002424"
                    },
                    Items = new List<InvoiceItem>()
                    {
                        new InvoiceItem()
                        {
                            Id = 1,
                            Item = "Item 1",
                            Description = "Description of Item 1",
                            Quantity = 2,
                            UnitPrice = 10
                        },
                        new InvoiceItem()
                        {
                            Id = 2,
                            Item = "Item 2",
                            Description = "Description of Item 2",
                            Quantity = 1,
                            UnitPrice = 15
                        },
                        new InvoiceItem()
                        {
                            Id = 3,
                            Item = "Item 3",
                            Description = "Description of Item 3",
                            Quantity = 3,
                            UnitPrice = 8
                        },
                    }
                }
            };
        }
    }
}
