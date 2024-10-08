﻿using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System.Text;

namespace ExtratoPDF.Extractors;

    internal class PDFConverter
    {
    public static string Process(string file)
    {
        try
        {

            PdfReader reader = new(file);
            PdfDocument document = new(reader);

            int pages = document.GetNumberOfPages();

            StringBuilder sb = new();

            for (int i = 1; i <= pages; i++)
            {
                PdfPage page = document.GetPage(i);

                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                var text = PdfTextExtractor.GetTextFromPage(page, strategy);

                sb.Append(text);
            }

            return sb.ToString();
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);

            return "";
        }

    }
}
