using Syncfusion.Drawing;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace HtmlToPdfGenerator
{
    public static class InvoicePdfGenerator
    {
        public static void GenerateInvoice(string html)
        {
            PdfDocument pdfDocument = new PdfDocument();
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            BlinkConverterSettings blinkConverterSettings = new BlinkConverterSettings();
            blinkConverterSettings.ViewPortSize = new Size(400, 0);
            htmlConverter.ConverterSettings = blinkConverterSettings;

            pdfDocument = htmlConverter.Convert(html, baseurl: "");

            if(File.Exists("HTML-to-PDF.pdf"))
                File.Delete("HTML-to-PDF.pdf");
            FileStream fileStream = new FileStream("HTML-to-PDF.pdf", FileMode.CreateNew, FileAccess.ReadWrite);

            pdfDocument.Save(fileStream);
            pdfDocument.Close(true);

        }
    }
}
