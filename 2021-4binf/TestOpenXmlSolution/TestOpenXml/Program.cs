using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace TestOpenXml
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = ' ';
            Console.WriteLine("1) Crea DOCX");
            Console.WriteLine("2) Apri DOCX");
            Console.WriteLine("X) ESCI");
            while (choice.ToString().ToUpper() != "X")
            {
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1':
                        CreaDocx("Test.docx");
                        break;
                    case '2':
                        ApriDocx("Test.docx");
                        break;
                    default:
                        break;
                }
            }
        }

        private static void CreaDocx(string fileName)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;
            // Create Document
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body docBody = new Body();
                mainPart.Document.AppendChild(docBody);

                // Create a simple paragraph
                string paragraphContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent quam augue, tempus id metus in, laoreet viverra quam. Sed vulputate risus lacus, et dapibus orci porttitor non.";
                docBody.Append(CreaParagrafoSemplice(paragraphContent));

                // Create a complex paragraph
                docBody.Append(CreaParagrafoComplesso());

                // Create a paragraph setting the justification
                paragraphContent = "Nam eu tortor ut mi euismod eleifend in ut ante. Donec a ligula ante. Sed rutrum ex quam. Nunc id mi ultricies, vestibulum sapien vel, posuere dui.";
                docBody.Append(CreaParagrafoGiustificato(paragraphContent, JustificationValues.Center));
                docBody.Append(CreaParagrafoGiustificato(paragraphContent, JustificationValues.Right));

                // Create a title
                paragraphContent = "My Test Title";
                Paragraph pTitle = CreaParagrafoSemplice(paragraphContent);
                docBody.Append(pTitle);
                ParagraphProperties pPr = CreaStileTitolo(pTitle, wordDocument);
                pTitle.PrependChild<ParagraphProperties>(pPr);

                // Create a Table
                docBody.Append(CreaTabella());

                // Create a Bullet list
                foreach (Paragraph item in CreaBulletList())
                {
                    docBody.Append(item);
                }
                //docBody.Append(CreaBulletList());


                Console.WriteLine("\nDOCX created!\n");
            }
        }

        private static List<Paragraph> CreaBulletList()
        {
            List<Paragraph> paragraphList = new List<Paragraph>();

            // Paragraph properties
            SpacingBetweenLines sblUl = new SpacingBetweenLines() { After = "0" };  // Get rid of space between bullets  
            Indentation iUl = new Indentation() { Left = "indentation", Hanging = "360" };  // correct indentation  
            NumberingProperties npUl = new NumberingProperties(
                new NumberingLevelReference() { Val = 1 },
                new NumberingId() { Val = 2 }
            );
            ParagraphProperties ppUnordered = new ParagraphProperties(npUl, sblUl, iUl);
            ppUnordered.ParagraphStyleId = new ParagraphStyleId() { Val = "ListParagraph" };

            // Pargraph
            Paragraph p1 = new Paragraph();
            p1.ParagraphProperties = new ParagraphProperties(ppUnordered.OuterXml);
            p1.Append(new Run(new Text("A")));
            paragraphList.Add(p1);
            //docBody.Append(p1);
            Paragraph p2 = new Paragraph();
            p2.ParagraphProperties = new ParagraphProperties(ppUnordered.OuterXml);
            p2.Append(new Run(new Text("Unordored")));
            paragraphList.Add(p2);
            //docBody.Append(p2);
            Paragraph p3 = new Paragraph();
            p3.ParagraphProperties = new ParagraphProperties(ppUnordered.OuterXml);
            p3.Append(new Run(new Text("List")));
            paragraphList.Add(p3);
            //docBody.Append(p3);


            return paragraphList;
        }

        private static Table CreaTabella()
        {
            Table table = new Table();
            TableRow tableRow1 = new TableRow();

            TableCell tableCell11 = new TableCell();
            Paragraph paragraph11 = new Paragraph(new Run(new Text("A")));
            tableCell11.Append(paragraph11);
            tableRow1.Append(tableCell11);

            TableCell tableCell12 = new TableCell();
            Paragraph paragraph12 = new Paragraph();
            Run run12 = new Run();
            RunProperties runProperies12 = new RunProperties();
            runProperies12.Bold = new Bold();
            run12.Append(runProperies12);
            run12.Append(new Text("Nice"));
            paragraph12.Append(run12);
            tableCell12.Append(paragraph12);

            tableRow1.Append(tableCell12);
            table.Append(tableRow1);


            TableRow tableRow2 = new TableRow();

            TableCell tableCell21 = new TableCell();
            Paragraph paragraph21 = new Paragraph(new Run(new Text("Little")));
            tableCell21.Append(paragraph21);
            tableRow2.Append(tableCell21);

            TableCell tableCell22 = new TableCell();
            Paragraph paragraph22 = new Paragraph();
            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            paragraphProperties22.Justification = new Justification() { Val = JustificationValues.Center };
            paragraph22.Append(paragraphProperties22);
            paragraph22.Append(new Run(new Text("Table")));
            tableCell22.Append(paragraph22);
            tableRow2.Append(tableCell22);

            table.Append(tableRow2);

            return table;
        }

        private static ParagraphProperties CreaStileTitolo(Paragraph pTitle, WordprocessingDocument wordDocument)
        {
            StyleDefinitionsPart styleDefinitionsPart = wordDocument.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
            styleDefinitionsPart.Styles = new Styles();
            Style style = new Style()
            {
                Type = StyleValues.Paragraph,
                StyleId = "Heading1",
                CustomStyle = true
            };
            StyleName styleName1 = new StyleName() { Val = "Heading1" };
            style.Append(styleName1);
            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            styleRunProperties1.Append(new Bold());
            styleRunProperties1.Append(new Italic());
            styleRunProperties1.Append(new RunFonts() { Ascii = "Lucida Console" });
            styleRunProperties1.Append(new FontSize() { Val = "24" });  // Sizes are in half-points. Oy!
            style.Append(styleRunProperties1);
            styleDefinitionsPart.Styles.Append(style);
            ParagraphProperties pPr = new ParagraphProperties();
            pPr.ParagraphStyleId = new ParagraphStyleId() { Val = "Heading1" };
            return pPr;
        }

        private static Paragraph CreaParagrafoGiustificato(string paragraphContent, JustificationValues justification)
        {
            Paragraph p = new Paragraph();
            ParagraphProperties pp = new ParagraphProperties();
            pp.Justification = new Justification() { Val = justification };
            // Add paragraph properties to your paragraph
            p.Append(pp);
            // Run
            Run r = new Run();
            Text t = new Text(paragraphContent) { Space = SpaceProcessingModeValues.Preserve };
            r.Append(t);
            p.Append(r);
            return p;
        }

        private static Paragraph CreaParagrafoComplesso()
        {
            Paragraph p = new Paragraph();
            // Run 1
            Run r1 = new Run();
            Text t1 = new Text("Pellentesque ") { Space = SpaceProcessingModeValues.Preserve };
            // The Space attribute preserve white space before and after your text
            r1.Append(t1);
            p.Append(r1);

            // Run 2 - Bold
            Run r2 = new Run();
            RunProperties rp2 = new RunProperties();
            rp2.Bold = new Bold();
            // Always add properties first
            r2.Append(rp2);
            Text t2 = new Text("commodo ") { Space = SpaceProcessingModeValues.Preserve };
            r2.Append(t2);
            p.Append(r2);

            // Run 3
            Run r3 = new Run();
            Text t3 = new Text("rhoncus ") { Space = SpaceProcessingModeValues.Preserve };
            r3.Append(t3);
            p.Append(r3);

            // Run 4 – Italic
            Run r4 = new Run();
            RunProperties rp4 = new RunProperties();
            rp4.Italic = new Italic();
            // Always add properties first
            r4.Append(rp4);
            Text t4 = new Text("mauris") { Space = SpaceProcessingModeValues.Preserve };
            r4.Append(t4);
            p.Append(r4);

            // Run 5
            Run r5 = new Run();
            Text t5 = new Text(", sit ") { Space = SpaceProcessingModeValues.Preserve };
            r5.Append(t5);
            p.Append(r5);

            // Run 6 – Italic , bold and underlined
            Run r6 = new Run();
            RunProperties rp6 = new RunProperties();
            rp6.Italic = new Italic();
            rp6.Bold = new Bold();
            rp6.Underline = new Underline();
            // Always add properties first
            r6.Append(rp6);
            Text t6 = new Text("amet ") { Space = SpaceProcessingModeValues.Preserve };
            r6.Append(t6);
            p.Append(r6);

            // Run 7
            Run r7 = new Run();
            Text t7 = new Text("faucibus arcu ") { Space = SpaceProcessingModeValues.Preserve };
            r7.Append(t7);
            p.Append(r7);

            // Run 8 – Red color
            Run r8 = new Run();
            RunProperties rp8 = new RunProperties();
            rp8.Color = new Color() { Val = "FF0000" };
            // Always add properties first
            r8.Append(rp8);
            Text t8 = new Text("porttitor ") { Space = SpaceProcessingModeValues.Preserve };
            r8.Append(t8);
            p.Append(r8);

            // Run 9
            Run r9 = new Run();
            Text t9 = new Text("pharetra. Maecenas quis erat quis eros iaculis placerat ut at mauris.") { Space = SpaceProcessingModeValues.Preserve };
            r9.Append(t9);
            p.Append(r9);

            // Add your paragraph to docx body
            return p;
        }

        private static Paragraph CreaParagrafoSemplice(string paragraphContent)
        {
            Paragraph paragraph = new Paragraph();
            Run run = new Run();
            Text text = new Text(paragraphContent);
            run.Append(text);
            paragraph.Append(run);
            return paragraph;
        }

        private static void ApriDocx(string fileName)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
