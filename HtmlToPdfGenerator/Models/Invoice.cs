namespace HtmlToPdfGenerator.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceItem> Items { get; set; }
    }
}
