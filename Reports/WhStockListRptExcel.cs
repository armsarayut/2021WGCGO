using System;
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
    public class WhStockListRptExcel
    {
        MemoryStream _memoryStream = new MemoryStream();
        //List<Vrpt_shelf_listInfo> ListReport = new List<Vrpt_shelf_listInfo>();
        public byte[] Report(List<Inv_Stock_GoInfo> ListRpt)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("2.1");
                #region Excel Report Header
                var imagePath = VarGlobals.Imagelogoreport();
                worksheet.Column(1).Width = 18;
                worksheet.Row(1).Height = 60;
                var image = worksheet.AddPicture(imagePath).MoveTo(worksheet.Cell("A1")); //this will throw an error
                image.ScaleWidth(.7);
                image.ScaleHeight(.7);
                worksheet.Cell("B1").Value = "2.1.Stocklist" + " - Report";
                worksheet.Cell("B1").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                worksheet.Cell("B2").Value = $"PrintDate : {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                #endregion Excel

                #region Excel Report Data
                var rptRows = 4;
                worksheet.Cell(rptRows, 1).Value = "ITEMCODE";
                worksheet.Cell(rptRows, 2).Value = "ITEMNAME";
                worksheet.Cell(rptRows, 3).Value = "STOCK";
                worksheet.Cell(rptRows, 4).Value = "LOT";
                worksheet.Cell(rptRows, 5).Value = "SEQ";
                worksheet.Cell(rptRows, 6).Value = "PALLET";
                worksheet.Cell(rptRows, 7).Value = "AREA";
                worksheet.Cell(rptRows, 8).Value = "LOCATION";

                foreach (var rpt in ListRpt)
                {
                    rptRows++;
                    worksheet.Cell(rptRows, 1).Value = rpt.Itemcode;
                    worksheet.Cell(rptRows, 2).Value = rpt.Itemname;
                    worksheet.Cell(rptRows, 3).Value = rpt.Quantity;
                    worksheet.Cell(rptRows, 4).Value = rpt.Docno;
                    worksheet.Cell(rptRows, 5).Value = rpt.Pallettag;
                    worksheet.Cell(rptRows, 6).Value = rpt.Pallteno;
                    worksheet.Cell(rptRows, 7).Value = rpt.Storagearea;
                    worksheet.Cell(rptRows, 8).Value = rpt.Storagebin;
                }
                #endregion
                workbook.SaveAs(_memoryStream);
            }
            return _memoryStream.ToArray();
        }
    }
}
