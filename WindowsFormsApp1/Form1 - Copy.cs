using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string starupPath = Application.StartupPath;
            string filePath = starupPath + "\\PDFGenerator\\BankStatement.pdf";
            string imagesPath = starupPath + "\\Images\\SBOLogo.jpg";

            if (File.Exists(filePath))

            {

                File.Delete(filePath);

            }

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);

            Document doc = new Document();

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            BaseFont bf1 = BaseFont.CreateFont(
            BaseFont.COURIER,
            BaseFont.CP1252,
            BaseFont.EMBEDDED);
            Font font1 = new Font(bf1, 7);

            var logo = iTextSharp.text.Image.GetInstance(imagesPath);

            logo.SetAbsolutePosition(40, 800);

            logo.ScaleAbsoluteHeight(40);

            logo.ScaleAbsoluteWidth(80);

            doc.Add(logo);

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));







            doc.Add(new Paragraph("Account Name                          :" + this.textBox_AccountName.Text, font1));

            string[] addressValues = this.textBox_Address.Text.Split(',');
            for (int index = 0; index < addressValues.Length;index++)
            {
                if(index==0)
                    doc.Add(new Paragraph("Address                               :"+ addressValues[index], font1));
                else
                    doc.Add(new Paragraph("                                       "+addressValues[index], font1));

            }

           // doc.Add(new Paragraph("Address                               :Hitechcity", font1));

            //doc.Add(new Paragraph("                                       Madhapur", font1));

            //doc.Add(new Paragraph("                                       Hyderabad-500082", font1));

            doc.Add(new Paragraph("Date                                  :" + DateTime.Today.ToString("dd-MMM-yyyy"), font1));

            doc.Add(new Paragraph("Account Number                        :" + this.textBox_AccountNumber.Text, font1));

            doc.Add(new Paragraph("Account Description                   : " + textBox_AccountDescription.Text, font1));

            doc.Add(new Paragraph("Branch                                : " + textBox_Branch.Text, font1));



            doc.Add(new Paragraph("Drawing Power                         :" + textBox_DrawingPower.Text, font1));

            doc.Add(new Paragraph("Interest Rate(%)                      : " + textBox_InterestRate.Text, font1));

            doc.Add(new Paragraph("MOD Balance                           : " + textBox_MODBalance.Text, font1));

            doc.Add(new Paragraph("CIF No.                               : " + textBox_CIFNumber.Text, font1));



            doc.Add(new Paragraph("IFSC Code                             :" + textBox1_IFSCCode.Text, font1));

            doc.Add(new Paragraph("MICR Code                             : " + textBox_MICRCode.Text, font1));

            doc.Add(new Paragraph("Nomination Registered                 : " + comboBox_NominationRegistered.Text, font1));

            doc.Add(new Paragraph("Balance as on " + DateTime.Today.ToString("dd-MMM-yyyy") + "           : 145745825", font1));




            doc.Add(new Chunk("\n"));

            BaseFont bf = BaseFont.CreateFont(

                        BaseFont.COURIER_BOLD,

                        BaseFont.CP1252,

                        BaseFont.EMBEDDED);

            Font font = new Font(bf, 10);

            Font font2 = new Font(bf1, 10);

            Paragraph paragraph = new Paragraph("Account statement from "+ dateTimePicker_FromDate.Value.ToString("dd-MMM-yyyy")+" to "+dateTimePicker_ToDate.Value.ToString("dd-MMM-yyyy"), font2);

            doc.Add(new Chunk("\n"));

            DataTable dt = GetDataTable();



            if (dt != null)

            {

                //BaseFont bf1 = BaseFont.CreateFont(

                //        BaseFont.TIMES_ROMAN,

                //        BaseFont.CP1252,

                //        BaseFont.EMBEDDED);

                //Font font1 = new Font(bf, 8);

                //Craete instance of the pdf table and set the number of column in that table

                PdfPTable PdfTable = new PdfPTable(dt.Columns.Count);

                int count = dt.Columns.Count;
//PdfPTable table = new PdfPTable(count);
                float[] columnWidths = new float[count];
                for (int v = 0; v < count; v++)
                {
                    if (v == 0)
                    {
                        columnWidths[v] = 30f;
                    }
                    else if (v == 1)
                    {
                        columnWidths[v] = 30f;
                    }
                    else if (v == 2)
                    {
                        columnWidths[v] = 50f;
                    }
                    else if (v == 3)
                    {
                        columnWidths[v] = 40f;
                    }
                    else if (v == 4)
                    {
                        columnWidths[v] = 35f;
                    }
                    else if (v == 5 || v == 6 || v == 7)
                    {
                        columnWidths[v] = 35f;
                    }
                    else
                    {
                        columnWidths[v] = 35f;
                    }
                }

                PdfTable.SetWidths(columnWidths);           







                PdfTable.WidthPercentage = 100f;

                //PdfTable.TotalWidth = doc.RightMargin - doc.LeftMargin;

                PdfTable.HorizontalAlignment = 0;

               /// PdfTable.SetTotalWidth(new float[] { 400 });

                PdfPCell PdfPCell = null;

                //PdfTable.TotalWidth = 295f;
                //Add Header of the pdf table

                PdfPCell = new PdfPCell(new Phrase(new Chunk("Txn Date", font)));

                //PdfPCell.Width = 200;

                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Value Date", font)));

                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Description", font)));

                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Ref No./Cheque No.", font)));

                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Debit", font)));
                PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Credit", font)));
                PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                PdfTable.AddCell(PdfPCell);

                PdfPCell = new PdfPCell(new Phrase(new Chunk("Balance", font)));
                PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                PdfTable.AddCell(PdfPCell);





                //How add the data from datatable to pdf table

                for (int rows = 0; rows < dt.Rows.Count; rows++)

                {

                    for (int column = 0; column < dt.Columns.Count; column++)

                    {

                        PdfPCell = new PdfPCell(new Phrase(new Chunk(dt.Rows[rows][column].ToString(), font1)));
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                        PdfTable.AddCell(PdfPCell);

                    }

                }



                PdfTable.SpacingBefore = 15f; // Give some space after the text or it may overlap the table



                doc.Add(paragraph);// add paragraph to the document

                doc.Add(PdfTable); // add pdf table to the document




                doc.Close();
            }
        }

            private static DataTable GetDataTable()

            {

                // Create an object of DataTable class

                DataTable dataTable = new DataTable("MyDataTable");//Create ID DataColumn

                DataColumn dataColumn_TxnDate = new DataColumn("Txn Date", typeof(string));

                dataTable.Columns.Add(dataColumn_TxnDate);//Create another DataColumn Name

                DataColumn dataColumn_ValuDate = new DataColumn("Value/nDate", typeof(string));

                dataTable.Columns.Add(dataColumn_ValuDate);



                DataColumn dataColumn_Dsc = new DataColumn("Description", typeof(string));

                dataTable.Columns.Add(dataColumn_Dsc);//Create another DataColumn Name

                DataColumn dataColumn_RefNo = new DataColumn("Ref No./Cheque/n No.", typeof(string));

                dataTable.Columns.Add(dataColumn_RefNo);



                DataColumn dataColumn_Debit = new DataColumn("Debit", typeof(string));

                dataTable.Columns.Add(dataColumn_Debit);//Create another DataColumn Name

                DataColumn dataColumn_Credit = new DataColumn("Credit", typeof(string));

                dataTable.Columns.Add(dataColumn_Credit);



                DataColumn dataColumn_Balance = new DataColumn("Balance", typeof(string));

                dataTable.Columns.Add(dataColumn_Balance);

                //Now Add some row to newly created dataTable

                DataRow dataRow; for (int i = 0; i < 5; i++)

                {

                    dataRow = dataTable.NewRow();

                    // Important you have create New row

                    dataRow["Txn Date"] = "12 Feb 2019";//Convert.ToString(DateTime.Today);

                    dataRow["Value/nDate"] = "12 Feb 2019";// Convert.ToString(DateTime.Today);

                    dataRow["Description"] = "Debit-SMS- CHARGES Jun-AUG-2019";

                    dataRow["Ref No./Cheque/n No."] = "IHJ8183460TRANSFER TO 62397292163";

                    dataRow["Debit"] = Convert.ToString(i) + ".00";

                    dataRow["Credit"] = Convert.ToString(i) + ".00";

                    dataRow["Balance"] = Convert.ToString(i + 1000) + ".00";

                    dataTable.Rows.Add(dataRow);

                }

                dataTable.AcceptChanges();

                return dataTable;

            }


        }


    }


