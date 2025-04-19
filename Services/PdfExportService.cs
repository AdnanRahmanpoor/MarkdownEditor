using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Markdig;
using MarkdownEditor.Models;

public static class PdfExportService
{
    public static void ExportToPdf(string markdown, string filePath, PageSettings settings)
    {
        var document = new PdfDocument();
        var page = document.AddPage();
        page.Width = settings.Width;
        page.Height = settings.Height;

        using (XGraphics gfx = XGraphics.FromPdfPage(page))
        {
            XFont font = new XFont("Arial", 12);
            var text = Markdown.ToPlainText(markdown);
            XRect layout = new XRect(
                settings.Margins.Left,
                settings.Margins.Top,
                page.Width - settings.Margins.Left - settings.Margins.Right,
                page.Height - settings.Margins.Top - settings.Margins.Bottom
                );
            gfx.DrawString(text, font, XBrushes.Black, layout);
        }

        document.Save(filePath);
    }
}