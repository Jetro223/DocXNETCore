using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = Novacode.DocX.Create(@"MyFile.docx");
            var p = doc.InsertParagraph();
            p.Append("Hello World");
            var i = doc.AddImage(@"purple.png");
            var p2 = doc.InsertParagraph();
            p2.AppendPicture(i.CreatePicture());
            doc.Save();

        }
    }
}
