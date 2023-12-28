using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.IO;

namespace PDFMerger
{
    static class PDFUtils
    {
        internal static void ConcatenatePDF(string[] inputFiles, string outFilename)
        {
            int count = 0;
            // Open the output document
            using (PdfDocument outputDocument = new PdfDocument())
            {
                // Iterate files
                foreach (string inputFile in inputFiles)
                {
                    using (PdfDocument inputDocument = PdfReader.Open(inputFile, PdfDocumentOpenMode.Import))
                    {
                        count = inputDocument.PageCount;
                        for (int idx = 0; idx < count; idx++)
                        {
                            PdfPage page = inputDocument.Pages[idx];
                            outputDocument.AddPage(page);
                        }
                    }
                }
                outputDocument.Save(outFilename);
            }
        }

        internal static bool CombinePDF(string[] inputFiles, string outFileName)
        {
            if (inputFiles.Length == 2)
            {
                using (PdfDocument outputDocument = new PdfDocument())
                {
                    int oddPage = 0;
                    int evenPage = 0;
                    PdfDocument inputDocument1 = PdfReader.Open(inputFiles[0], PdfDocumentOpenMode.Import);
                    PdfDocument inputDocument2 = PdfReader.Open(inputFiles[1], PdfDocumentOpenMode.Import);
                    while (true)
                    {
                        if (inputDocument1.PageCount > oddPage)
                        {
                            PdfPage page1 = inputDocument1.Pages[oddPage++];
                            outputDocument.AddPage(page1);
                        } 
                        if (inputDocument2.PageCount > evenPage)
                        {
                            PdfPage page2 = inputDocument2.Pages[evenPage++];
                            outputDocument.AddPage(page2);
                        } 
                        if((inputDocument1.PageCount <= oddPage) && (inputDocument2.PageCount <= evenPage))
                        {
                            break;
                        }
                    }
                    outputDocument.Save(outFileName);
                    inputDocument1.Dispose();
                    inputDocument2.Dispose();
                }
                return true;
            }
            else
                return false;
        }

        internal static bool SplitPDF(string[] inputFiles)
        {
            foreach(string inputFile in inputFiles)
            {
                // Open the file
                PdfDocument inputDocument = PdfReader.Open(inputFile, PdfDocumentOpenMode.Import);
                string filename = Path.GetFileNameWithoutExtension(inputFile);
                Console.WriteLine(filename);
                for (int idx = 0; idx < inputDocument.PageCount; idx++)
                {
                    Console.WriteLine(idx);
                    using (PdfDocument outputDocument = new PdfDocument())
                    {
                        // Add the page and save it
                        outputDocument.AddPage(inputDocument.Pages[idx]);
                        outputDocument.Save(String.Format("{0} - Page {1}.pdf", filename, idx + 1));
                    }
                }
            }
            return true;
        }

        internal static int GetPageTotal(string pdfFilePath)
        {
            int pageTot = -1;
            using (PdfDocument inputDocument = PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Import))
            {
                pageTot = inputDocument.PageCount;
            }
            return pageTot;
        }
    }
}
