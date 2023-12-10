﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OfficeOpenXml;
using System.IO;
using Font = iTextSharp.text.Font;

namespace LTUD1_MF_BHX.ScreenMenu.In
{
    public class ITextEvents : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            PdfPTable tabFot = new PdfPTable(new float[] { 1F });
            PdfPCell cell;
            tabFot.TotalWidth = 300F;
            cell = new PdfPCell(new Phrase("Trang " + writer.PageNumber));
            tabFot.AddCell(cell);
            tabFot.WriteSelectedRows(0, -1, 150, document.Bottom, writer.DirectContent);
        }
    }
    public class InFilePDF
    {
        DataGridView dgv;
        SaveFileDialog sfd;
        public InFilePDF(DataGridView dgv, SaveFileDialog sfd)
        {
            this.dgv = dgv;
            this.sfd = sfd;
        }

        public DataGridView Dgv { get => dgv; set => dgv = value; }
        public SaveFileDialog Sfd { get => sfd; set => sfd = value; }

        public void ExportToPDF()
        {
            Thread thread = new Thread(() => Clipboard.SetText("Test!"));
            thread.SetApartmentState(ApartmentState.STA); // Đặt luồng này thành STA
            thread.Start();
            thread.Join(); // Chờ luồng kết thúc
            if (dgv.Rows.Count > 0)
            {
                //SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Đường dẫn đến thư mục chứa các font chữ hệ thống
                            string systemFontsPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);

                            // Tạo một font chữ từ file font trên hệ thống của bạn
                            BaseFont bf = BaseFont.CreateFont(Path.Combine(systemFontsPath, "segoeui.ttf"), BaseFont.IDENTITY_H, BaseFont.EMBEDDED)!;
                            Font font = new Font(bf!, 8, Font.NORMAL);

                            // Sử dụng font chữ này khi tạo các cell cho PdfPTable
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                                    }
                                    else
                                    {
                                        pdfTable.AddCell(new Phrase("", font));
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                writer.PageEvent = new ITextEvents();
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }


        public void ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet 1");
                        ws.Cells["A1"].LoadFromDataTable((DataTable)dgv.DataSource, true);
                        Byte[] bin = pck.GetAsByteArray();
                        File.WriteAllBytes(sfd.FileName, bin);
                    }
                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo");
                }
            }
        }

    }
}
