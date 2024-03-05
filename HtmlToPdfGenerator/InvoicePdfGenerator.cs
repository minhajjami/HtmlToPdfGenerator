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

            var filePath = "../../../sample.pdf";

            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fileStream = new FileStream(filePath, FileMode.CreateNew, FileAccess.ReadWrite);

            pdfDocument.Save(fileStream);
            pdfDocument.Close(true);
        }
    }
}
