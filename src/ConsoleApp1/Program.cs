using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novacode;
using DocX = Novacode.DocX;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var doc = Novacode.DocX.Load(@"Test.docx");

            Hyperlink h = doc.AddHyperlink("Google", new Uri("http://www.google.com"));

            // Add a new Paragraph to this document.
            Paragraph p = doc.InsertParagraph();
            p.Append("My favourite search engine is ");
            p.AppendHyperlink(h);
            p.Append(", I think it's great.");
            doc.Paragraphs[0].Append("blahblah").Bold();
            doc.Save();
        }
    }
}
