// See https://aka.ms/new-console-template for more information


using Novacode;

var doc = DocX.Create(@"MyFile.docx");
var p = doc.InsertParagraph();
p.Append("Hello World");
var i = doc.AddImage("purple.png");
var p2 = doc.InsertParagraph();
p2.AppendPicture(i.CreatePicture());

doc.AddHeaders();
var pic = i.CreatePicture();
var hp = doc.Headers.odd.InsertParagraph();
hp.InsertPicture(pic);
hp.InsertParagraphBeforeSelf(doc.InsertParagraph());

doc.Save();