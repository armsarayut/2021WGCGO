﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using GoWMS.Server.Data;
using GoWMS.Server.Models.Wcs;

namespace GoWMS.Server.Reports
{
    public class RptAsrsRejectRptExcel
    {
        MemoryStream _memoryStream = new MemoryStream();
        //List<Inb_Goodreceipt_Go> _Inb_Goodreceive_Go_s = new List<Inb_Goodreceipt_Go>();
        public byte[] Report(List<Rpt_Ejectgate> rptElements)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("5.5.7");
                #region Excel Report Header
                var imagePath = VarGlobals.Imagelogoreport();
                worksheet.Column(1).Width = 18;
                worksheet.Row(1).Height = 60;
                var image = worksheet.AddPicture(imagePath).MoveTo(worksheet.Cell("A1")); //this will throw an error
                image.ScaleWidth(.7);
                image.ScaleHeight(.7);
                worksheet.Cell("B1").Value = "5.5.7.ASRS-EJECT" + " - Report";
                worksheet.Cell("B1").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                worksheet.Cell("B2").Value = $"PrintDate : {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                #endregion Excel

                #region Excel Report Data
                var rptRows = 4;
                worksheet.Cell(rptRows, 1).Value = "DATETIME";
                worksheet.Cell(rptRows, 2).Value = "PALLET";
                worksheet.Cell(rptRows, 3).Value = "REASON";
                worksheet.Cell(rptRows, 4).Value = "WEIGHT";
                worksheet.Cell(rptRows, 5).Value = "SIZE";
                worksheet.Cell(rptRows, 6).Value = "GATE";

                foreach (var rpt in rptElements)
                {
                    rptRows++;
                    worksheet.Cell(rptRows, 1).Value = Convert.ToDateTime(rpt.Created).ToString(VarGlobals.FormatDT);
                    worksheet.Cell(rptRows, 2).Value = rpt.Lpncode;
                    worksheet.Cell(rptRows, 3).Value = rpt.Msg;
                    worksheet.Cell(rptRows, 4).Value = string.Format(VarGlobals.FormatN2, rpt.Actual_Weight);
                    worksheet.Cell(rptRows, 5).Value = rpt.Actual_Size;
                    worksheet.Cell(rptRows, 6).Value = rpt.Work_Gate;
                }
                #endregion
                workbook.SaveAs(_memoryStream);
            }
            return _memoryStream.ToArray();
        }

    }
}
