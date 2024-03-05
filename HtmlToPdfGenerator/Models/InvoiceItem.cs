namespace HtmlToPdfGenerator.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
