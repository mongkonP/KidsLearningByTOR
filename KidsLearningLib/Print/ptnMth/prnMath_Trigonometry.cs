﻿
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
  public   class prnMath_Trigonometry : prnClass
    {

        #region Variables

        int minValue, maxValue;
        int countC = 13;
        // List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion
        public prnMath_Trigonometry()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ มุมในรูป สามเหลี่ยม และ รูปสี่เหลี่ยม ";//Please convert the following units to be correct. 

        }

       
        int ic = 0;
        #region Print Page Trigonometry_1


        public void PrintFromTrigonometry_1(int count = 10)
        {

            _ReportToppic = "ให้วัดมุมต่อไปนี้ ";
          
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromTrigonometry_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromTrigonometry_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            
            for (int i = 0; i < 8; i++)
            {
              
                string Eq =  $"จำนวน  {RandomNumber.NextNumber(-10,10)} ";
               
                e.Graphics.DrawImage(Properties.Resources.เส้นจำนวน__10_ถึง_14, xC-60, yC + 60 );
                e.Graphics.DrawString(Eq, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                yC += 120;

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
