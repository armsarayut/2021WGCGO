﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using GoWMS.Server.Models.Inv;
using GoWMS.Server.Data;

namespace GoWMS.Server.Reports
{
    public class WhShelfListPageRptPdf : PdfPageEvents
    {
        #region Attributes
        readonly string reportCaption = "2.3.Location - Report";
        readonly Boolean bPageLanscape = false;
        #endregion

        #region GenerateHeader
        /// <summary>
        /// Generate header
        /// </summary>
        /// <param name="fontFilePath"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public override PdfPTable GenerateHeader(iTextSharp.text.pdf.PdfWriter writer)
        {
            BaseFont baseFont = BaseFontForHeaderFooter;
            iTextSharp.text.Font font_logo = new iTextSharp.text.Font(baseFont, 20, iTextSharp.text.Font.BOLD, BaseColor.Blue);
            iTextSharp.text.Font font_header1 = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, BaseColor.Blue);
            iTextSharp.text.Font font_header2 = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD,BaseColor.Blue);
            iTextSharp.text.Font font_headerContent = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.Blue);

            float[] widths = new float[] { 50, 350, 90, 120, 90, 40, 10 };

            PdfPTable header = new PdfPTable(widths);
            PdfPCell cell = new PdfPCell
            {
                BorderWidthBottom = 1,
                BorderWidthLeft = 0,
                BorderWidthTop = 0,
                BorderWidthRight = 0,
                FixedHeight = 35,
                Phrase = new Phrase("", font_logo),
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                PaddingTop = -1
            };
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_CENTER);
            cell.Phrase = new Paragraph(reportCaption, font_header2);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("Printed :", font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_LEFT);
            cell.Phrase = new Paragraph(DateTime.UtcNow.ToString("g"), font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("Page :", font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_CENTER);
            cell.Phrase = new Paragraph(writer.PageNumber.ToString(), font_headerContent);
            header.AddCell(cell);

            cell = GenerateOnlyBottomBorderCell(2, iTextSharp.text.Element.ALIGN_RIGHT);
            cell.Phrase = new Paragraph("", font_headerContent);
            header.AddCell(cell);
            return header;
        }


        #region GenerateOnlyBottomBorderCell
        /// <summary>
        /// Generate a cell with only the bottom edge
        /// </summary>
        /// <param name="bottomBorder"></param>
        /// <param name="horizontalAlignment">Horizontal alignment<see cref="iTextSharp.text.Element"/></param>
        /// <returns></returns>
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder,
                                                            int horizontalAlignment)
        {
            PdfPCell cell = GenerateOnlyBottomBorderCell(bottomBorder, horizontalAlignment, iTextSharp.text.Element.ALIGN_CENTER);
            cell.PaddingBottom = 5;
            return cell;
        }

        /// <summary>
        /// Generate a cell with only the bottom edge
        /// </summary>
        /// <param name="bottomBorder"></param>
        /// <param name="horizontalAlignment">Horizontal alignment<see cref="iTextSharp.text.Element"/></param>
        /// <param name="verticalAlignment">Vertical alignment<see cref="iTextSharp.text.Element"/</param>
        /// <returns></returns>
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder,
                                                            int horizontalAlignment,
                                                            int verticalAlignment)
        {
            PdfPCell cell = GenerateOnlyBottomBorderCell(bottomBorder);
            cell.HorizontalAlignment = horizontalAlignment;
            cell.VerticalAlignment = verticalAlignment; ;
            return cell;
        }

        /// <summary>
        /// Generate a cell with only the bottom edge
        /// </summary>
        /// <param name="bottomBorder"></param>
        /// <returns></returns>
        private PdfPCell GenerateOnlyBottomBorderCell(int bottomBorder)
        {
            PdfPCell cell = new PdfPCell
            {
                BorderWidthBottom = 1,
                BorderWidthLeft = 0,
                BorderWidthTop = 0,
                BorderWidthRight = 0
            };
            return cell;
        }
        #endregion

        #endregion

        #region GenerateFooter
        public override PdfPTable GenerateFooter(iTextSharp.text.pdf.PdfWriter writer)
        {
            BaseFont baseFont = BaseFontForHeaderFooter;
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.Blue);

            PdfPTable footer = new PdfPTable(3);
            AddFooterCell(footer, "Informer : .................", font);
            AddFooterCell(footer, "Checker : .................", font);
            AddFooterCell(footer, "Approver : .................", font);
            return footer;
        }

        private void AddFooterCell(PdfPTable foot, String text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell
            {
                BorderWidthTop = 0,
                BorderWidthRight = 0,
                BorderWidthBottom = 0,
                BorderWidthLeft = 0,
                Phrase = new Phrase(text, font),
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
            };
            foot.AddCell(cell);
        }
        #endregion

        #region ExportPDF
        /// <summary>
        /// Export PDF
        /// </summary>
        /// <param name="ListRpt">List Data</param>
        /// <returns></returns>
        public byte[] ExportPDF(List<Vrpt_shelf_listInfo> ListRpt)
        {
            WhShelfListPageRptPdf pdfReport = new WhShelfListPageRptPdf();
            Document document;
            if (bPageLanscape)
            {
                document = new Document(PageSize.A4.Rotate(), 10f, 10f, 60f, 30f); // Setup page Protrait
            }
            else
            {
                document = new Document(PageSize.A4, 10f, 10f, 60f, 30f); // Setup page Protrait
            }
            MemoryStream ms = new MemoryStream();
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, ms);
            pdfWriter.PageEvent = pdfReport;//You must assign a value here to trigger the processing of the header and footer
            document.Open();
            pdfReport.ReportBody(document, ListRpt);
            // pdfReport.AddBody(document);
            document.Close();
            byte[] buff = ms.ToArray();
            return buff;
        }
        #endregion

        #region AddBody
        /// <summary>
        /// Table Report
        /// </summary>
        /// <param name="document"></param>
        /// <param name="ListRpts">List<Vrpt_shelf_listInfo></param>
        /// <returns></returns>
        private void ReportBody(Document document, List<Vrpt_shelf_listInfo> ListRpts)
        {
            BaseFont baseFont = BaseFontForHeaderFooter;
  
            int maxColum = 8;
            float[] sizes = new float[maxColum];
            for (var i = 0; i < maxColum; i++) // Set up Colum Size
            {
                if (i == 0) sizes[i] = 1f;
                else if (i == 1) sizes[i] = 0.6f;
                else if (i == 2) sizes[i] = 0.6f;
                else if (i == 3) sizes[i] = 0.6f;
                else if (i == 4) sizes[i] = 0.6f;
                else if (i == 5) sizes[i] = 1.5f;
                else if (i == 6) sizes[i] = 3.5f;
                else if (i == 7) sizes[i] = 2f;
                else sizes[i] = 1f;
            }
            PdfPTable bodyTable = new PdfPTable(sizes)
            {
                WidthPercentage = 100,
                HorizontalAlignment = Element.ALIGN_LEFT
            };
           
            PdfPCell cell = new PdfPCell();

            iTextSharp.text.Font _fontstyeheader = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, BaseColor.Black);

            #region Table Header
            iTextSharp.text.BaseColor headerBackcolor = BaseColor.White;
            cell = new PdfPCell(new Phrase("LOCATION", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("LANE", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("BANK", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
        };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("BAY", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("LEVEL", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("PALLET", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("STATUS", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("LASTUPDATE", _fontstyeheader))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = headerBackcolor,
                BorderWidth = Rectangle.NO_BORDER
            };
            bodyTable.AddCell(cell);

            bodyTable.CompleteRow();
            #endregion

            #region Table Body
            iTextSharp.text.Font _fontstyebody = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.Black);
            iTextSharp.text.BaseColor bodyBackcolor = BaseColor.White;
            iTextSharp.text.BaseColor LineBorderColor = BaseColor.LightGray;
            foreach (var listRpt in ListRpts)
            {
                cell = new PdfPCell(new Phrase(listRpt.Shelfcode.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Srm_no.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Shelfbank.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Shelfbay.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Shelflevel.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Lpncode.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.St_desc.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                cell = new PdfPCell(new Phrase(listRpt.Modified.ToString(), _fontstyebody))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    BackgroundColor = bodyBackcolor,
                    BorderWidthTop = 0.5f,
                    BorderWidthRight = 0f,
                    BorderWidthBottom = 0f,
                    BorderWidthLeft = 0f,
                    BorderColorTop = LineBorderColor
                };
                bodyTable.AddCell(cell);

                bodyTable.CompleteRow();
            }
            #endregion

            bodyTable.HeaderRows = 1; // Setup table headers in all the pages
            document.Add(bodyTable);
        }
        #endregion
    }

}
