﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using GoWMS.Server.Data;
using GoWMS.Server.Models.Inv;

namespace GoWMS.Server.Reports
{
    public class WhShelfListPageRptExcel
    {
        MemoryStream _memoryStream = new MemoryStream();
        //List<Vrpt_shelf_listInfo> ListReport = new List<Vrpt_shelf_listInfo>();
        public byte[] Report(List<Vrpt_shelf_listInfo> ListRpt)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("2.3");
                #region Excel Report Header
                var imagePath = VarGlobals.Imagelogoreport();
                worksheet.Column(1).Width = 18;
                worksheet.Row(1).Height = 60;
                var image = worksheet.AddPicture(imagePath).MoveTo(worksheet.Cell("A1")); //this will throw an error
                image.ScaleWidth(.7);
                image.ScaleHeight(.7);
                worksheet.Cell("B1").Value = "2.3.Location" + " - Report";
                worksheet.Cell("B1").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                worksheet.Cell("B2").Value = $"PrintDate : {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                #endregion Excel

                #region Excel Report Data
                var rptRows = 4;
                worksheet.Cell(rptRows, 1).Value = "LOCATION";
                worksheet.Cell(rptRows, 2).Value = "LANE";
                worksheet.Cell(rptRows, 3).Value = "BANK";
                worksheet.Cell(rptRows, 4).Value = "BAY";
                worksheet.Cell(rptRows, 5).Value = "LEVEL";
                worksheet.Cell(rptRows, 6).Value = "PALLET";
                worksheet.Cell(rptRows, 7).Value = "STATUS";
                worksheet.Cell(rptRows, 8).Value = "LASTUPDATE";

                foreach (var rpt in ListRpt)
                {
                    rptRows++;
                    worksheet.Cell(rptRows, 1).Value = rpt.Shelfcode;
                    worksheet.Cell(rptRows, 2).Value = rpt.Srm_no;
                    worksheet.Cell(rptRows, 3).Value = rpt.Shelfbank;
                    worksheet.Cell(rptRows, 4).Value = rpt.Shelfbay;
                    worksheet.Cell(rptRows, 5).Value = rpt.Shelflevel;
                    worksheet.Cell(rptRows, 6).Value = rpt.Lpncode;
                    worksheet.Cell(rptRows, 7).Value = rpt.St_desc;
                    worksheet.Cell(rptRows, 8).Value = rpt.Modified;
                }
                #endregion
                workbook.SaveAs(_memoryStream);
            }
            return _memoryStream.ToArray();
        }
    }
}
