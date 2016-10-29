using System;
using System.IO;
using Novacode;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ms = new MemoryStream();
            var doc = Novacode.DocX.Load(@"Test.docx", ms);

            Hyperlink h = doc.AddHyperlink("Google", new Uri("http://www.google.com"));

            // Add a new Paragraph to this document.
            Paragraph p = doc.InsertParagraph();
            p.Append("My favourite search engine is ");
            p.AppendHyperlink(h);
            p.Append(", I think it's great.");
            doc.Paragraphs[0].Append("blahblah").Bold();

            // Add header support to this document.

            oc.SaveAs(@"Copy2.docx");

        }
    }
}
