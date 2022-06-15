using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using TORServices.Maths;


using static TORServices.Maths.extMath;
using TORServices.Drawings;
namespace KidsLearningLib.Print
{

    public class prnMath_Statistics : prnClass
    {
        #region Variables

        int countC = 13;

        #endregion
        public prnMath_Statistics()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ สถิติ/Statistics ";//Please convert the following units to be correct. 
           // _ReportToppic = "เขียนชื่อหน่วยนับ และ เลข อุปสรรค ต่อไปนี้ให้ถูกต้อง";
        }
       
       
        int ic = 0;

        #region Print Page Statistics_1
        public void PrintFrom_Statistics_1(int count = 10)
        {
            _ReportToppic = "สถิติเบื้องต้น";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;

            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFrom_Statistics_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }
        }
        protected override void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
           

            base.printDocumentNewPage(sender, e);

        }
        protected void PrintFrom_Statistics_1PrintPage(object sender, PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            int numCount = 0;
            string numString = "";
            for (int i = 0; i < 4; i++)
            {

                int a = RandomNumber.NextNumber(5, 20);
                int b = Convert.ToInt32(a * 50 / 100);
                numCount = RandomNumber.NextNumber(5, 15);
                numString = "";
                for (int x = 1; x <= numCount; x++)
                {
                    numString += "  " + RandomNumber.NextNumber(a-b, a+b) ;
                }

                //  numString = "จากข้อมูล ตัวเลขต่อไปนี้ \n" + numString + "\n \n \n \n \n";
                e.Graphics.DrawString("จากข้อมูล ตัวเลขต่อไปนี้ " + numString, new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC + 5);
                yC += 25;
                e.Graphics.DrawString("1.เรียงจาก น้อยไปมาก ได้ดังนี้ ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC );
                yC += 25;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 50, yC + 20, xC + 340, yC + 20);
                yC += 25;
                e.Graphics.DrawString("2.จำนวนข้อมูล = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC );
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("3.ค่าต่ำสุด = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("4.ค่าสูงสุด = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC );
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("5.ค่าพิสัย (Range) = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("6.ค่ามัธยฐาน (Median)  = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("7.ฐานนิยม (Mode) = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC );
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);


                yC += 35;

            }

            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;

        }


        #endregion

        #region Print Page Statistics_2
        public void PrintFrom_Statistics_2(int count = 10)
        {
            _ReportToppic = "สถิติเบื้องต้น";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;

            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFrom_Statistics_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }
        }

        protected void PrintFrom_Statistics_2PrintPage(object sender, PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            int numCount = 0;
            string numString = "";
            for (int i = 0; i < 4; i++)
            {

                int a = RandomNumber.NextNumber(5, 20);
                int b = Convert.ToInt32(a * 50 / 100);
                numCount = RandomNumber.NextNumber(5, 15);
                numString = "";
                for (int x = 1; x <= numCount; x++)
                {
                    numString += "  " + RandomNumber.NextNumber(a - b, a + b);
                }

                //  numString = "จากข้อมูล ตัวเลขต่อไปนี้ \n" + numString + "\n \n \n \n \n";
                e.Graphics.DrawString("จากข้อมูล ตัวเลขต่อไปนี้ " + numString, new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC + 5);
                yC += 25;
                e.Graphics.DrawString("1.เรียงจาก น้อยไปมาก ได้ดังนี้ ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                yC += 25;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 50, yC + 20, xC + 340, yC + 20);
                yC += 25;
                e.Graphics.DrawString("2.จำนวนข้อมูล = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("3.ผลรวมของข้อมูล = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("4.ค่าเฉลี่ย (Mean) = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);


                yC += 35;

            }

            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;

        }


        #endregion
    }
}
