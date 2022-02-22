﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using GoWMS.Server.Data;
using GoWMS.Server.Models.Inb;

namespace GoWMS.Server.Reports
{
    public class IbpWcsQueueRptExcel
    {
        MemoryStream _memoryStream = new MemoryStream();
        //List<Inb_Goodreceipt_Go> _Inb_Goodreceive_Go_s = new List<Inb_Goodreceipt_Go>();
        public byte[] Report(List<Inb_Putaway_Go> rptElements)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("1.3");
                #region Excel Report Header
                var imagePath = VarGlobals.Imagelogoreport();
                worksheet.Column(1).Width = 18;
                worksheet.Row(1).Height = 60;
                var image = worksheet.AddPicture(imagePath).MoveTo(worksheet.Cell("A1")); //this will throw an error
                image.ScaleWidth(.7);
                image.ScaleHeight(.7);
                worksheet.Cell("B1").Value = "1.3.Master Queuing" + " - Report";
                worksheet.Cell("B1").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                worksheet.Cell("B2").Value = $"PrintDate : {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                #endregion Excel

                #region Excel Report Data
                var rptRows = 4;
                worksheet.Cell(rptRows, 1).Value = "Queuetime";
                worksheet.Cell(rptRows, 2).Value = "Pallet";
                worksheet.Cell(rptRows, 3).Value = "Tasktype";
                worksheet.Cell(rptRows, 4).Value = "SRM";
                worksheet.Cell(rptRows, 5).Value = "Location";
                worksheet.Cell(rptRows, 6).Value = "Starttime";
                worksheet.Cell(rptRows, 7).Value = "Endtime";

                foreach (var rpt in rptElements)
                {
                    rptRows++;
                    worksheet.Cell(rptRows, 1).Value = rpt.Created;
                    worksheet.Cell(rptRows, 2).Value = rpt.Palletno;
                    worksheet.Cell(rptRows, 3).Value = rpt.Puttype;
                    worksheet.Cell(rptRows, 4).Value = rpt.Storagearea;
                    worksheet.Cell(rptRows, 5).Value = rpt.Storagebin;
                    worksheet.Cell(rptRows, 6).Value = rpt.Storagetime;
                    worksheet.Cell(rptRows, 7).Value = rpt.Completed;
                }
                #endregion
                workbook.SaveAs(_memoryStream);
            }
            return _memoryStream.ToArray();
        }
    }
}
