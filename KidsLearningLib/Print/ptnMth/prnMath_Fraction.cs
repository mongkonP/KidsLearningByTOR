﻿
using KidsLearningLib.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TORServices.Maths;

namespace KidsLearningLib.Print
{
   public class prnMath_Fraction : prnClass
    {
        #region Variables

        int minValue, maxValue;
        int countC = 13;
        // List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion
        public prnMath_Fraction()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ เศษส่วน ";//Please convert the following units to be correct. 
    
        }


        int ic = 0;
        #region Print Page Fraction_1


        public void PrintFromFraction_1(int count = 10)
        {

            _ReportToppic = "ให้เขียนเศษส่วนเกินต่อไปนี้ให้เป็นจำนวนคละ ";
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromFraction_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromFraction_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {
              
                int a = RandomNumber.NextNumber(3, 10);
                int b = RandomNumber.NextNumber(1, 10);
                int c = RandomNumber.NextNumber(1, a-1);
                int d = a * b + c;
                e.Graphics.DrawFraction(0,d, a, xC + 10, yC,false,false,false);
                e.Graphics.DrawString(" = ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 120, yC + 20);
                e.Graphics.DrawFraction(b, d, a, xC + 200, yC, true, true, false);


                yC += 100;

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

        #region Print Page Fraction_2


        public void PrintFromFraction_2(int count = 10)
        {

            _ReportToppic = "ให้ผล บวก ลบ เศษส่วนต่อไปนี้ ";
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromFraction_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromFraction_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {

                int a = RandomNumber.NextNumber(3, 10);
                int _b = RandomNumber.NextNumber(1, 10);
                int _c = RandomNumber.NextNumber(1,10);
                int b = Math.Max(_b, _c);
                int c = Math.Min(_b, _c);

                e.Graphics.DrawFraction(0, b, a, xC + 10, yC,false,false,false,false);
                e.Graphics.DrawString((RandomNumber.NextNumber(1, 1000)>500)?" + ":" - ", new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 70, yC + 15);
                e.Graphics.DrawFraction(0, c, a, xC + 80, yC, false, false, false, false);
                e.Graphics.DrawString( " = ", new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 135, yC + 15);
                e.Graphics.DrawFraction(0, c, a, xC + 150, yC, true, false, true,false);

                yC += 100;

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


        #region Print Page LongDivision_1

      public  enum LongDivisionOption { IntegerNum, MixedNum, DecimalNum,RandomNum}

        private LongDivisionOption longDivisionOption;
        public void PrintFromLongDivision_1(int count = 10, LongDivisionOption _longDivisionOption = LongDivisionOption.IntegerNum)
        {
            longDivisionOption = _longDivisionOption;
            _ReportToppic = "หาผลหาร ต่อไปนี้";
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromLongDivision_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromLongDivision_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 5; i++)
            {

                int a = RandomNumber.NextNumber(2, 9);
                int _b = RandomNumber.NextNumber(15, 100);
                int b = 0 ;
                if (longDivisionOption == LongDivisionOption.IntegerNum)
                {
                    b = a * _b;
                }
                else if (longDivisionOption == LongDivisionOption.DecimalNum || longDivisionOption == LongDivisionOption.MixedNum)
                {
                    b = a * _b + RandomNumber.NextNumber(1, _b);
                }
                else if (longDivisionOption == LongDivisionOption.RandomNum)
                {
                    if (RandomNumber.NextNumber(1, 1000) > 500)
                    {
                        b = a * _b;
                    }
                    else
                    {
                        b = a * _b + RandomNumber.NextNumber(1, _b);
                    }
                
                }
                

                e.Graphics.DrawString($"{b} ÷ { a} = ? ", new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 50, yC + 15);
                
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC , xC + 500, yC);
                 e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 250, yC + 25);
                //e.Graphics.DrawString(")", new Font("Angsana New", 28), new SolidBrush(Color.Black), xC + 200, yC);
                yC += 32;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC, xC + 240, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                yC += 15;

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
