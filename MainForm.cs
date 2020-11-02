using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MeiTools;

namespace 条码打印器
{
    public partial class mainForm : Form
    {
        List<Bitmap> barCodeImages = new List<Bitmap>();
        int printCounter = 0;
        #region 初始化条码打印参数
        int barCodeWidth = 300;
        int barCodeHeight = 100;
        int barCodeSpacing = 50;
        int fontSize = 14;
        #endregion
        PrintDocument batchPrintDocument = new PrintDocument();

        public mainForm()
        {
            InitializeComponent();
            CustomInit();
        }

        private void CustomInit()
        {
            #region 初始化打印机列表
            foreach (string s in PrinterSettings.InstalledPrinters)
            {
                cbPrinters.Items.Add(s);
            }
            PrintDocument print = new PrintDocument();
            cbPrinters.SelectedItem = print.PrinterSettings.PrinterName;
            print.Dispose();
            #endregion
            batchPrintDocument.PrintPage += BatchPrint;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string codeString = tbCodeString.Text;
            if (!string.IsNullOrWhiteSpace(codeString))
            {
                Bitmap barCodeImage = ObjectOperator.CreateBarCode(codeString, 300, 100);
                pictureBoxBarCode.Image = barCodeImage;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (pictureBoxBarCode.Image != null)
            {
                PrintDocument pd = new PrintDocument();
                try
                {
                    pd.PrintPage += singlePrint;
                    pd.PrinterSettings.PrinterName = cbPrinters.SelectedItem.ToString();
                    PageSetupDialog pageSetupDialog = new PageSetupDialog();
                    pageSetupDialog.Document = pd;
                    if (DialogResult.OK == pageSetupDialog.ShowDialog())
                    {
                        pd.Print();
                        MessageBox.Show("打印完成!");
                    }
                }
                catch (Exception ePrint)
                {
                    MessageBox.Show($"打印失败：\r\n{ePrint})", "打印失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                { pd.Dispose(); }
            }
            else
            {
                MessageBox.Show("请先生成图像");
            }

        }

        private void singlePrint(object sender, PrintPageEventArgs ea)
        {
            PrintDocument pd = (PrintDocument)sender;
            //Font printFont = new Font("微软雅黑", 12);
            int paperWidth = pd.DefaultPageSettings.PaperSize.Width;
            //int paperWidth=e.MarginBounds.Width;
            int paperHeight = pd.DefaultPageSettings.PaperSize.Height;
            //int paperHeight = e.MarginBounds.Height;
            int imgWidth = pictureBoxBarCode.Image.Width;
            int imgHeight = pictureBoxBarCode.Image.Height;

            if (imgWidth < paperWidth && imgHeight < paperHeight)
            {
                int sectionWidth = imgWidth + 30;
                int sectionHeight = imgHeight + 30;

                int row = paperHeight / sectionHeight;
                int column = paperWidth / sectionWidth;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        ea.Graphics.DrawImage(pictureBoxBarCode.Image, 0 + j * sectionWidth, 0 + i * sectionHeight);  //img大小
                        //ea.Graphics.DrawString(messageTB1.Text, printFont, Brushes.Black, (0 + j * sectionWidth)+100, (0 + i * sectionHeight)+105);
                    }
                }
                ea.HasMorePages = false;
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            lbBarCodes.Items.Clear();
            string filename = (string)FileOperator.OpenFile(fileFilter: "Excel文件（*.xls,*.xlsx）|*.xls;*.xlsx");
            string[,] barCodeStrings = FileOperator.GetExcelRangeData(filename);
            if (barCodeStrings != null)
            {
                for (int i = 0; i <= barCodeStrings.GetUpperBound(0); i++)
                {
                    if (!string.IsNullOrWhiteSpace(barCodeStrings[i, 0]))
                        lbBarCodes.Items.Add(barCodeStrings[i, 0]);
                }
            }

        }

        private void btnBatchPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBarCodeWidth.Text))
            {
                barCodeWidth = int.Parse(tbBarCodeWidth.Text);
            }
            if (!string.IsNullOrWhiteSpace(tbBarcodeHeight.Text))
            {
                barCodeHeight = int.Parse(tbBarcodeHeight.Text);
            }
            if (!string.IsNullOrWhiteSpace(tbBarCodeSpacing.Text))
            {
                barCodeSpacing = int.Parse(tbBarCodeSpacing.Text);
            }
            if (!string.IsNullOrWhiteSpace(tbFontSize.Text))
            {
                fontSize = int.Parse(tbFontSize.Text);
            }


            barCodeImages.Clear();
            printCounter = 0;
            if (lbBarCodes.Items.Count > 0)
            {
                foreach (string s in lbBarCodes.Items)
                {
                    barCodeImages.Add(ObjectOperator.CreateBarCode(s, barCodeWidth, barCodeHeight, true));
                }
                //PrintDocument batchPrintDocument = new PrintDocument();
                try
                {
                    batchPrintDocument.PrinterSettings.PrinterName = cbPrinters.SelectedItem.ToString();
                    //PageSetupDialog pageSetupDialog = new PageSetupDialog();
                    //pageSetupDialog.Document = batchPrintDocument;
                    //if (DialogResult.OK == pageSetupDialog.ShowDialog())
                    //{
                    //batchPrintDocument.PrintPage += BatchPrint;
                    PrintPreviewDialog ppd = new PrintPreviewDialog();
                    ppd.Document = batchPrintDocument;
                    ppd.ShowDialog();


                    //}
                }
                catch (Exception ePrint)
                {
                    MessageBox.Show($"打印失败：\r\n{ePrint})", "打印失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //finally
                //{ batchPrintDocument.Dispose(); }
            }
            else
            { MessageBox.Show("无可打印数据"); }
        }

        private void BatchPrint(object sender, PrintPageEventArgs ea)
        {
            int pagePrinterCounter = 0;
            Font printFont = new Font("微软雅黑", fontSize);
            ////int paperWidth = pd.DefaultPageSettings.PaperSize.Width;
            int printWidth = ea.MarginBounds.Width;
            ////int paperHeight = pd.DefaultPageSettings.PaperSize.Height;
            int printHeight = ea.MarginBounds.Height;
            int imgWidth = barCodeImages[0].Width;
            int imgHeight = barCodeImages[0].Height;

            int sectionWidth = imgWidth + 10;
            int sectionHeight = imgHeight;

            string labelString = lbBarCodes.Items[printCounter].ToString();
            Graphics graphics = CreateGraphics();
            SizeF sizeF = graphics.MeasureString(labelString, printFont);
            int strWidth = (int)sizeF.Width;
            int strHeight = (int)sizeF.Height;
            graphics.Dispose();

            int pageRow = printHeight / (sectionHeight + strHeight + barCodeSpacing);
            int pageColumn = printWidth / sectionWidth;

            if (pageRow * pageColumn > 0)
            {
                int x = ea.MarginBounds.X, y = ea.MarginBounds.Y;
                while (pagePrinterCounter < pageRow * pageColumn && printCounter < barCodeImages.Count)
                {
                    /*//x=100,y=137,662   30号字，A4一页两张的参数
                    int int x = 100, y = 0;
                    if (pagePrinterCounter == 0)
                    {
                        y = 137;
                    }
                    else
                    {
                        y = 662;
                    }
                    */
                    for (int i = 0; i < pageRow; i++)
                    {
                        for (int j = 0; j < pageColumn; j++)
                        {
                            if (printCounter < barCodeImages.Count)
                            {

                                int offset = ((sectionWidth - strWidth) / 2);
                                int x1 = x + j * sectionWidth, y1 = y + i * (sectionHeight + strHeight + barCodeSpacing);
                                labelString = lbBarCodes.Items[printCounter].ToString();
                                ea.Graphics.DrawImage(barCodeImages[printCounter], x1, y1);
                                ea.Graphics.DrawString(labelString, printFont, Brushes.Black, x1 + offset, y1 + sectionHeight);
                                pagePrinterCounter++;
                                printCounter++;
                            }
                        }
                    }
                }

                if (printCounter < barCodeImages.Count)
                {
                    ea.HasMorePages = true;
                }
                else
                {
                    printCounter = 0;//预览打印 和 打印 都会调用 BatchPrint() 一遍，所以如果printConter不被重置为0，则打印函数默认为打印已结束，所以会出现预览成功后，按打印却出来空白页的原因。
                    ea.HasMorePages = false;
                }
            }
            else
            {
                MessageBox.Show("纸张太小，无法打印");
            }
        }

        private void validatingNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void btnPageSetting_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = batchPrintDocument;
            psd.AllowPrinter = true;
            if (DialogResult.OK == psd.ShowDialog())
            {
                #region 修复.Net Pagesetup的Bug，把百万分之一英寸改为十分之一毫米
                psd.PageSettings.Margins.Top = PrinterUnitConvert.Convert(psd.PageSettings.Margins.Top, PrinterUnit.Display, PrinterUnit.TenthsOfAMillimeter);
                psd.PageSettings.Margins.Bottom = PrinterUnitConvert.Convert(psd.PageSettings.Margins.Bottom, PrinterUnit.Display, PrinterUnit.TenthsOfAMillimeter);
                psd.PageSettings.Margins.Left = PrinterUnitConvert.Convert(psd.PageSettings.Margins.Left, PrinterUnit.Display, PrinterUnit.TenthsOfAMillimeter);
                psd.PageSettings.Margins.Right = PrinterUnitConvert.Convert(psd.PageSettings.Margins.Right, PrinterUnit.Display, PrinterUnit.TenthsOfAMillimeter);
                #endregion
            }
        }
    }
}

