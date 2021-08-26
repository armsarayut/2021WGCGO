using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Models.Inb;
using GoWMS.Server.Data;

namespace GoWMS.Server.Reports
{
    public class IbpOrderQueueRptPdf
    {
        readonly BaseFont mpdfFont = BaseFont.CreateFont(VarGlobals.Fontreport(), BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // Setup Font
        #region Declararion
        int _maxcolun = 8;
        Document _document;
        PdfPTable _pdfTable = new PdfPTable(8);
        PdfPCell _pdfCell;
        Font _fontstye;
        readonly Boolean bPageLanscape = false;

        MemoryStream _memoryStream = new MemoryStream();
        List<Inb_Goodreceive_Go> _Inb_Goodreceive_Go_s = new List<Inb_Goodreceive_Go>();

        #endregion
        public byte[] Report(List<Inb_Goodreceive_Go> Inb_Goodreceive_Go_s)
        {
            _Inb_Goodreceive_Go_s = Inb_Goodreceive_Go_s;
            if (bPageLanscape)
            {
                _document = new Document(PageSize.A4.Rotate(), 10f, 10f, 30f, 10f); // Setup page Lascape
            }
            else
            {
                _document = new Document(PageSize.A4, 10f, 10f, 30f, 10f); // Setup page Protrait
            }
            
            
            _pdfTable.WidthPercentage = 100;
            _pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfWriter.GetInstance(_document, _memoryStream);
            this.ReportHeader();
            this.ReportFooter();
            _document.Open();
            this.ReportLogo();

            float[] sizes = new float[_maxcolun];
            for (var i = 0; i < _maxcolun; i++) // Set up Colum Size
            {
                if (i == 0) sizes[i] = 70;
                else if (i == 1) sizes[i] = 70;
                else if (i == 2) sizes[i] = 90;
                else if (i == 3) sizes[i] = 70;
                else if (i == 4) sizes[i] = 100;
                else if (i == 5) sizes[i] = 150;
                else if (i == 6) sizes[i] = 70;
                else if (i == 7) sizes[i] = 50;
                else sizes[i] = 100;
            }
            _pdfTable.SetTotalWidth(sizes);
            this.ReportBody();
            _document.Add(_pdfTable);
            _document.Close();
            return _memoryStream.ToArray();
        }

        private void ReportHeader()
        {
            //  Header
            _fontstye = new Font(mpdfFont, 12f, 1);
            var labelHeader = new Chunk("Good Receive", _fontstye);
            HeaderFooter header = new HeaderFooter(new Phrase(labelHeader), false)
            {
                Alignment = Element.ALIGN_CENTER
            };
            _document.Header = header;
        }
        private void ReportFooter()
        {
            // Footer
            _fontstye = new Font(mpdfFont, 10f, 0);
            var labelFooter = new Chunk("Page ", _fontstye);
            HeaderFooter footer = new HeaderFooter(new Phrase(labelFooter), true)
            {
                Border = Rectangle.NO_BORDER,
                Alignment = Element.ALIGN_CENTER
            };
            _document.Footer = footer;
        }
        private void ReportLogo()
        {
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(GoWMS.Server.Data.VarGlobals.Imagelogoreport());
            png.ScaleAbsolute(40, 40);
            if (bPageLanscape)
            {
                png.SetAbsolutePosition(10, 550);
            }
            else
            {
                png.SetAbsolutePosition(10, 797);
            }
                
            _document.Add(png);
        }

        private void ReportBody()
        {
            _fontstye = new Font(mpdfFont, 9f, 0);
            #region Table Header
            iTextSharp.text.BaseColor headerBackcolor = BaseColor.LightGray;

            _pdfCell = new PdfPCell(new Phrase("QueuDate", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Masterpallet", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Ducument", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("PackID", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Material", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Description", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Qty", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Unit", _fontstye))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor
            };
            _pdfTable.AddCell(_pdfCell);

            _pdfTable.CompleteRow();
            #endregion

            #region Table Body
            _fontstye = new Font(mpdfFont, 9f, 0);
            iTextSharp.text.BaseColor bodyBackcolor = BaseColor.White;
            foreach (var listRpt in _Inb_Goodreceive_Go_s)
            {
                _pdfCell = new PdfPCell(new Phrase(listRpt.Created.ToString(), _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Pallteno, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Docno, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Itemtag, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Itemcode, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Itemname, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Quantity.ToString(), _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(listRpt.Unit, _fontstye))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor
                };
                _pdfTable.AddCell(_pdfCell);

                _pdfTable.CompleteRow();
            }
            #endregion
        }
    }
}
