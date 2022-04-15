using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwebWMS.UI
{
    public class PdfHelper
    {
        /// <summary>
        /// 生成pdf
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="Datas">数据</param>
        public static void CreatePdf(string filePath, Dictionary<string, string> Datas)
        {
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {

                    Document docPDF = new Document(PageSize.A4, 100, 100, 80, 80);
                    //创建一个pdf文档的对象
                    PdfWriter write = PdfWriter.GetInstance(docPDF, fs);//创建一个写入PDF的对象
                    BaseFont bsFont = BaseFont.CreateFont(@"C:\Windows\Fonts\simhei.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bsFont);          //在这里需要注意的是，itextsharp不支持中文字符，想要显示中文字符的话需要自己设置字体
                    docPDF.Open();                         //打开
                    PdfPTable tablerow1 = new PdfPTable(new float[] { 180, 140, 140 });
                    tablerow1.TotalWidth = PageSize.A4.Width - 160; //表格宽度
                    tablerow1.LockedWidth = true;
                    if (Datas.Count > 0)
                    {
                        List<PdfPCell> list1 = new List<PdfPCell>();
                        List<PdfPCell> list2 = new List<PdfPCell>();
                        foreach (var data in Datas)
                        {
                            if (data.Key == "图片")
                            {
                                PdfPCell cell1 = new PdfPCell(new Paragraph(data.Key, font));
                                cell1.HorizontalAlignment = 1;
                                cell1.PaddingBottom = 5;
                                cell1.PaddingTop = 5;
                                cell1.BorderColor = BaseColor.WHITE;
                                cell1.SetLeading(1.2f, 1.2f);
                                list1.Add(cell1);
                                if (File.Exists(data.Value))
                                {
                                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(data.Value);
                                    img.ScaleToFit(new iTextSharp.text.Rectangle(90, 90));
                                    PdfPCell cell11 = new PdfPCell(img);
                                    cell11.HorizontalAlignment = 1;
                                    cell11.PaddingBottom = 5;
                                    cell11.PaddingTop = 5;
                                    cell11.BorderColor = BaseColor.WHITE;
                                    cell11.SetLeading(1.2f, 1.2f);
                                    list2.Add(cell11);//将单元格添加到表格中} }

                                }
                                else
                                {
                                    PdfPCell cell11 = new PdfPCell(new Paragraph("", font));
                                    cell1.HorizontalAlignment = 1;
                                    cell1.PaddingBottom = 5;
                                    cell1.PaddingTop = 5;
                                    cell1.BorderColor = BaseColor.WHITE;
                                    cell1.SetLeading(1.2f, 1.2f);
                                    list2.Add(cell11);
                                }
                            }
                            else if (data.Key == "一维码")
                            {
                                PdfPCell cell3 = new PdfPCell(new Paragraph(data.Key, font));
                                cell3.HorizontalAlignment = 1;
                                cell3.PaddingBottom = 5;
                                cell3.PaddingTop = 5;
                                cell3.BorderColor = BaseColor.WHITE;
                                cell3.SetLeading(1.2f, 1.2f);
                                list1.Add(cell3);
                                Barcode128 code128 = new Barcode128();
                                code128.CodeType = Barcode.CODE128;
                                code128.ChecksumText = true;
                                code128.GenerateChecksum = true;
                                code128.StartStopText = true;
                                code128.Code = data.Value;
                                iTextSharp.text.pdf.PdfContentByte cb = write.DirectContent;
                                iTextSharp.text.Image img1 = code128.CreateImageWithBarcode(cb, null, null);
                                img1.ScaleToFit(new iTextSharp.text.Rectangle(90, 90));
                                PdfPCell cell4 = new PdfPCell(img1);
                                cell4.HorizontalAlignment = 1;
                                cell4.PaddingBottom = 5;
                                cell4.PaddingTop = 5;
                                cell4.BorderColor = BaseColor.WHITE;
                                cell4.SetLeading(1.2f, 1.2f);
                                list2.Add(cell4);//将单元格添加到表格中}
                            }
                            else if (data.Key == "二维码")
                            {
                                PdfPCell cell3 = new PdfPCell(new Paragraph(data.Key, font));
                                cell3.HorizontalAlignment = 1;
                                cell3.PaddingBottom = 5;
                                cell3.PaddingTop = 5;
                                cell3.BorderColor = BaseColor.WHITE;
                                cell3.SetLeading(1.2f, 1.2f);
                                list1.Add(cell3);
                                Dictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>();
                                hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");
                                BarcodeQRCode qRCode = new BarcodeQRCode(data.Value, 90, 90, hints);
                                iTextSharp.text.pdf.PdfContentByte cb = write.DirectContent;
                                iTextSharp.text.Image img1 = qRCode.GetImage();
                                img1.ScaleToFit(new iTextSharp.text.Rectangle(90, 90));
                                PdfPCell cell4 = new PdfPCell(img1);
                                cell4.HorizontalAlignment = 1;
                                cell4.PaddingBottom = 5;
                                cell4.PaddingTop = 5;
                                cell4.BorderColor = BaseColor.WHITE;
                                cell4.SetLeading(1.2f, 1.2f);
                                list2.Add(cell4);//将单元格添加到表格中}
                            }
                            else
                            {
                                PdfPCell cell1 = new PdfPCell(new Paragraph(data.Key, font));
                                cell1.HorizontalAlignment = 1;
                                cell1.PaddingBottom = 5;
                                cell1.PaddingTop = 5;
                                cell1.BorderColor = BaseColor.WHITE;
                                cell1.SetLeading(1.2f, 1.2f);
                                list1.Add(cell1);

                                PdfPCell cell11 = new PdfPCell(new Paragraph(data.Value, font));
                                cell11.HorizontalAlignment = 1;
                                cell11.PaddingBottom = 5;
                                cell11.PaddingTop = 5;
                                cell11.BorderColor = BaseColor.WHITE;
                                cell11.SetLeading(1.2f, 1.2f);
                                list2.Add(cell11);

                            }
                        }
                        int count = Datas.Count;
                        if (count % 3 == 1)
                        {
                            //造单元格
                            PdfPCell cell11 = new PdfPCell(new Paragraph("", font));
                            cell11.HorizontalAlignment = 1;
                            cell11.PaddingBottom = 10;
                            cell11.PaddingTop = 10;
                            cell11.BorderColor = BaseColor.WHITE;
                            cell11.SetLeading(1.2f, 1.2f);
                            list2.Add(cell11);
                            list2.Add(cell11);
                            list1.Add(cell11);
                            list1.Add(cell11);
                            count += 2;
                        }
                        else if (count % 3 == 2)
                        {
                            //造单元格
                            PdfPCell cell11 = new PdfPCell(new Paragraph("", font));
                            cell11.HorizontalAlignment = 1;
                            cell11.PaddingBottom = 10;
                            cell11.PaddingTop = 10;
                            cell11.BorderColor = BaseColor.WHITE;
                            cell11.SetLeading(1.2f, 1.2f);
                            list2.Add(cell11);
                            list1.Add(cell11);
                            count += 1;
                        }
                        for (int i = 0; i < count; i = i + 3)
                        {
                            tablerow1.AddCell(list1[i + 0]);
                            tablerow1.AddCell(list1[i + 1]);
                            tablerow1.AddCell(list1[i + 2]);
                            tablerow1.AddCell(list2[i + 0]);
                            tablerow1.AddCell(list2[i + 1]);
                            tablerow1.AddCell(list2[i + 2]);
                        }
                    }

                    docPDF.Add(tablerow1);//将表格添加到pdf文档中

                    docPDF.Close();                        //关闭
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private static bool JudgeFileExist(string url)
        {
            try
            {
                //创建根据网络地址的请求对象
                System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.CreateDefault(new Uri(url));
                httpWebRequest.Method = "HEAD";
                httpWebRequest.Timeout = 1000;
                //返回响应状态是否是成功比较的布尔值
                return (((System.Net.HttpWebResponse)httpWebRequest.GetResponse()).StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }
    }
}

