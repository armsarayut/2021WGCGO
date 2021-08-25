using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Models.Inb;

namespace GoWMS.Server.Pdf
{
    public class PdfInboundReport
    {
        #region Declararion
        int _maxcolun = 8;
        Document _document;
        PdfPTable _pdfTable = new PdfPTable(8);
        PdfPCell _pdfCell;
        Font _fontstye;
        MemoryStream _memoryStream = new MemoryStream();
        List<Inb_Goodreceive_Go> _Inb_Goodreceive_Go_s = new List<Inb_Goodreceive_Go>();
        #endregion
        public byte[] Report(List<Inb_Goodreceive_Go> Inb_Goodreceive_Go_s)
        {
            _Inb_Goodreceive_Go_s = Inb_Goodreceive_Go_s;
            _document = new Document(PageSize.A4, 10f, 10f, 20f, 30f);

            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(GoWMS.Server.Data.VarGlobals.Imagelogoreport());
            png.ScaleAbsolute(55, 55);
            png.SetAbsolutePosition(10, 780);

            _pdfTable.WidthPercentage = 100;
            _pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            _fontstye = FontFactory.GetFont("Tahoma", 8f, 1);
            PdfWriter.GetInstance(_document, _memoryStream);
            _document.Open();

            /*
            string image = GoWMS.Server.Data.VarGlobals.Imagelogoreport(); //$"{Directory.GetCurrentDirectory()}{@"\wwwroot\images\Logo.png"}";
            Image img = Image.GetInstance(image);
            img.ScaleAbsolute(30, 30);
            img.SetAbsolutePosition(10, 1);
            _document.Add(img);
            */

            
            _document.Add(png);



            float[] sizes = new float[_maxcolun];
            for (var i = 0; i < _maxcolun; i++)
            {
                if (i == 0) sizes[i] = 50;
                else sizes[i] = 100;
            }
            _pdfTable.SetTotalWidth(sizes);

            this.ReportHeader();
            this.ReportBody();

            _pdfTable.HeaderRows = 2;
            _document.Add(_pdfTable);
            _document.Close();

            return _memoryStream.ToArray();
        }

        private void ReportHeader()
        {
 
            _fontstye = FontFactory.GetFont("Tahoma", 18f, 1);
            _pdfCell = new PdfPCell(new Phrase("Good Receive", _fontstye));
            _pdfCell.Colspan = _maxcolun;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

            _pdfCell = new PdfPCell(new Phrase("-----------------------------", _fontstye));
            _pdfCell.Colspan = _maxcolun;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

        }
        private void ReportBody()
        {
            _fontstye = FontFactory.GetFont("Tahoma", 9f, 1);
            var fontstye = FontFactory.GetFont("Tahoma", 9f, 0);
            #region Table Header
            _pdfCell = new PdfPCell(new Phrase("No.", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Masterpallet", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Ducument", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("PackID", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Material", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Description", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Qty", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Unit", _fontstye));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.Gray;
            _pdfTable.AddCell(_pdfCell);

            _pdfTable.CompleteRow();
            #endregion

            #region Table Body
            int nSL = 1;
            foreach (var Inb_Goodreceive_Go_s in _Inb_Goodreceive_Go_s)
            {
                _pdfCell = new PdfPCell(new Phrase(nSL++.ToString(), fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Pallteno, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Docno, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Itemtag, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Itemcode, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Itemname, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Quantity.ToString(), fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(Inb_Goodreceive_Go_s.Unit, fontstye));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.White;
                _pdfTable.AddCell(_pdfCell);

                _pdfTable.CompleteRow();
            }
            #endregion
        }
        private void writeText(PdfContentByte cb, string Text, int X, int Y, BaseFont font, int Size)
        {
            cb.SetFontAndSize(font, Size);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Text, X, Y, 0);
        }

    }
}
