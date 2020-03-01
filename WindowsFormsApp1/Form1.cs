//using iTextSharp.text;
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
using System.Data.OleDb;
using System.Configuration;
using System.Xml;
using iTextSharp.text;
//using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static int totalBalance = 0;
        public static int salary = 0;
        public static DataTable dataTable = null;
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
            var FontColor = new BaseColor(35, 31, 32);
            var Arial9 = FontFactory.GetFont("Arial", 9, FontColor);

            if (File.Exists(filePath))

            {

                File.Delete(filePath);

            }

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);

            Document doc = new Document();

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            
            var Calibri7 = FontFactory.GetFont("Calibri", 10, FontColor);
            BaseFont bf1 = BaseFont.CreateFont(
            BaseFont.COURIER,
            BaseFont.CP1252,
            BaseFont.EMBEDDED);
            Font font1 = new Font(bf1, 7);

            var logo = iTextSharp.text.Image.GetInstance(imagesPath);

            logo.SetAbsolutePosition(35, 750);

            logo.ScaleAbsoluteHeight(55);

            logo.ScaleAbsoluteWidth(135);

           
         

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));
            doc.Add(logo);


            ReadxmlData(this.dateTimePicker_FromDate.Value.Date, this.dateTimePicker_ToDate.Value.Date);


            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Chunk("\n"));

            doc.Add(new Paragraph("                                                                                                                                      " +
                "                                                                                                                                                    " +
                "                                                                                                                                                      " +
                "                                                                                                                                                       " +
                "                                                                                                                                                         "));
            doc.Add(new Paragraph("Account Name                        : " + this.textBox_AccountName.Text, Arial9));

            string[] addressValues = this.textBox_Address.Text.Split(',');
            for (int index = 0; index < addressValues.Length;index++)
            {
                if(index==0)
                    doc.Add(new Paragraph("Address                                  : " + addressValues[index], Arial9));
                else
                    doc.Add(new Paragraph("                                                 "  + addressValues[index], Arial9));

            }

           // doc.Add(new Paragraph("Address                               :Hitechcity", font1));

            //doc.Add(new Paragraph("                                       Madhapur", font1));

            //doc.Add(new Paragraph("                                       Hyderabad-500082", font1));

            doc.Add(new Paragraph("Date                                        : " + DateTime.Today.ToString("d MMM yyyy"), Arial9));

            doc.Add(new Paragraph("Account Number                     : " + this.textBox_AccountNumber.Text, Arial9));

            doc.Add(new Paragraph("Account Description                : " + textBox_AccountDescription.Text, Arial9));

            doc.Add(new Paragraph("Branch                                    : " + textBox_Branch.Text, Arial9));



            doc.Add(new Paragraph("Drawing Power                       : " + textBox_DrawingPower.Text, Arial9));

            doc.Add(new Paragraph("Interest Rate(%)                     : " + textBox_InterestRate.Text, Arial9));

            doc.Add(new Paragraph("MOD Balance                         : " + textBox_MODBalance.Text, Arial9));

            doc.Add(new Paragraph("CIF No.                                   : " + textBox_CIFNumber.Text, Arial9));



            doc.Add(new Paragraph("IFSC Code                             : " + textBox1_IFSCCode.Text, Arial9));

            doc.Add(new Paragraph("MICR Code                            : " + textBox_MICRCode.Text, Arial9));

            doc.Add(new Paragraph("Nomination Registered"+"          :  " + comboBox_NominationRegistered.Text, Arial9));

            doc.Add(new Paragraph("Balance as on " +DateTime.Today.ToString("d MMM yyyy")+"     : "+totalBalance, Arial9));




            doc.Add(new Chunk("\n"));

            BaseFont bf = BaseFont.CreateFont(

                        BaseFont.COURIER_BOLD,

                        BaseFont.CP1252,

                        BaseFont.EMBEDDED);

            ////BaseFont baseFont = BaseFont.CreateFont("c:/windows/fonts/calibri.ttf",
                        //BaseFont.IDENTITY_H,
                        //BaseFont.EMBEDDED);
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", "Identity-H", BaseFont.EMBEDDED);
            var font = new Font(baseFont, 10, iTextSharp.text.Font.BOLD);
            // Font font = new Font(bf, 10);

            //Font font2 = new Font(bf1, 10);

            //var font = new Font(baseFont, 10);
            var font2 = new Font(baseFont, 14, iTextSharp.text.Font.NORMAL);

             


            var Calibri10 = FontFactory.GetFont("Calibri", 10, FontColor);
            var Arial12 = FontFactory.GetFont("Arial", 12, FontColor);

            Paragraph paragraph = new Paragraph("Account Statement from "+ dateTimePicker_FromDate.Value.ToString("d MMM yyyy")+" to "+dateTimePicker_ToDate.Value.ToString("d MMM yyyy"), Arial12);

            doc.Add(new Chunk("\n"));

            //DataTable dt = GetDataTable();



            if (dataTable != null)

            {

                PdfPTable PdfTable = new PdfPTable(dataTable.Columns.Count);

                int count = dataTable.Columns.Count;
                float[] columnWidths = new float[count];
                for (int v = 0; v < count; v++)
                {
                    if (v == 0)
                    {
                        columnWidths[v] = 24f;
                    }
                    else if (v == 1)
                    {
                        columnWidths[v] = 24f;
                    }
                    else if (v == 2)
                    {
                        columnWidths[v] = 65f;
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
                        columnWidths[v] = 32f;
                    }
                    else
                    {
                        columnWidths[v] = 32f;
                    }
                }

                PdfTable.SetWidths(columnWidths); 







                PdfTable.WidthPercentage = 100f;

                PdfTable.HorizontalAlignment = 0;

                PdfPCell PdfPCell = null;
                PdfPCell = new PdfPCell(new Phrase(new Chunk("Txn Date", font)));
                PdfTable.AddCell(PdfPCell);
                PdfPCell = new PdfPCell(new Phrase(new Chunk("Value Date", font)));
                PdfTable.AddCell(PdfPCell);
                PdfPCell = new PdfPCell(new Phrase(new Chunk("Description", font)));
                PdfTable.AddCell(PdfPCell);



                PdfPCell = new PdfPCell(new Phrase(new Chunk("Ref No./Cheque No.", font)));
                PdfPCell.FixedHeight = 20f;
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

                for (int rows = 0; rows < dataTable.Rows.Count; rows++)

                {

                    for (int column = 0; column < dataTable.Columns.Count; column++)

                    {

                        PdfPCell = new PdfPCell(new Phrase(new Chunk(dataTable.Rows[rows][column].ToString(), Arial9)));
                        if(column==2|| column==3)
                            PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                        else
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
            string starupPath = Application.StartupPath;
            string filePath = starupPath + "\\Data\\InputData.xlsx";
            //DataTable dataTable1 = ReadExcel(filePath, ".xls");

                DataTable dataTable = new DataTable("MyDataTable");//Create ID DataColumn

                DataColumn dataColumn_TxnDate = new DataColumn("Txn Date", typeof(string));

                dataTable.Columns.Add(dataColumn_TxnDate);//Create another DataColumn Name

                DataColumn dataColumn_ValuDate = new DataColumn("Value/nDate", typeof(string));

                dataTable.Columns.Add(dataColumn_ValuDate);



                DataColumn dataColumn_Dsc = new DataColumn("Description", typeof(string));

                dataTable.Columns.Add(dataColumn_Dsc);//Create another DataColumn Name

                DataColumn dataColumn_RefNo = new DataColumn("Ref No./Cheque/ No.", typeof(string));

                dataTable.Columns.Add(dataColumn_RefNo);



                DataColumn dataColumn_Debit = new DataColumn("Debit", typeof(string));

                dataTable.Columns.Add(dataColumn_Debit);//Create another DataColumn Name

                DataColumn dataColumn_Credit = new DataColumn("Credit", typeof(string));

                dataTable.Columns.Add(dataColumn_Credit);



                DataColumn dataColumn_Balance = new DataColumn("Balance", typeof(string));

                dataTable.Columns.Add(dataColumn_Balance);               

                DataRow dataRow; for (int i = 0; i < 10; i++)

                {

                    dataRow = dataTable.NewRow();

                    // Important you have create New row

                    dataRow["Txn Date"] = "12 Feb 2019";//Convert.ToString(DateTime.Today);

                    dataRow["Value/nDate"] = "12 Feb 2019";// Convert.ToString(DateTime.Today);

                    dataRow["Description"] = "Debit-SMS- CHARGES Jun-AUG-2019";

                    dataRow["Ref No./Cheque/ No."] = "IHJ8183460TRANSFER TO 62397292163";

                    dataRow["Debit"] = Convert.ToString(i) + ".00";

                    dataRow["Credit"] = Convert.ToString(i) + ".00";

                    dataRow["Balance"] = Convert.ToString(i + 1000) + ".00";

                    dataTable.Rows.Add(dataRow);

                }

                dataTable.AcceptChanges();

                return dataTable;

            }

        private static DataTable CreateDataTable()
        {
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
            return dataTable;
        }

        public static void ReadxmlData(DateTime fromDate,DateTime toDate)
        {
            totalBalance = Convert.ToInt32(ConfigurationManager.AppSettings["TotalBalance"]);
            dataTable = CreateDataTable();
           // DateTime fromDate = this.dateTimePicker_FromDate.Value.Date;
            //DateTime fromDate = DateTime.Today.AddMonths(-1);
            //DateTime toDate = DateTime.Today.AddMonths(2);

            XmlDocument xmlDoc = new XmlDocument();
            string filePath = Application.StartupPath + "\\Data\\InputData.xml";
            xmlDoc.Load(filePath);
            string sMonth = fromDate.ToString("MM");
            AddDataToTable(fromDate, toDate, xmlDoc, dataTable, true, sMonth);
        }

        private static void AddDataToTable(DateTime fromDate, DateTime toDate, XmlDocument xmlDoc, DataTable tableData, bool isFirstTime, string monthNumber)
        {
            string month = fromDate.ToString("MMM");
            string year = fromDate.ToString("yyyy");
            string day = fromDate.ToString("dd");
            XmlNode titleNode = xmlDoc.SelectSingleNode("//Root/Month[@Name='" + month + "']");


            //else
            //{
            foreach (XmlNode chileNode in titleNode.ChildNodes)
            {
                if (chileNode.Attributes[2].Value.Equals("Debit") && totalBalance < Convert.ToInt32(chileNode.Attributes[3].Value))
                {
                    continue;
                }
                if (isFirstTime)
                {
                    if (Convert.ToInt32(chileNode.Attributes[0].Value) >= Convert.ToInt32(day))
                    {
                        //int monthValue = Convert.ToInt32(monthNumber);
                        //int month11 = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(month) + 2;
                        string dateInString = month + " " + Convert.ToInt32(chileNode.Attributes[0].Value) + "," + " " + year;
                        DateTime parsedDate = DateTime.Parse(dateInString);
                        int value = DateTime.Compare(parsedDate, toDate);
                        if (value <= 0)
                        {
                            DataRow dataRow = tableData.NewRow();
                            // Important you have create New row
                            dataRow["Txn Date"] = chileNode.Attributes[0].Value + " "+month + " " + year; //Convert.ToString(DateTime.Today);
                            dataRow["Value/nDate"] = chileNode.Attributes[0].Value+" "+month +  " " + year;// Convert.ToString(DateTime.Today);
                            dataRow["Description"] = Convert.ToString(chileNode.Attributes[1].Value);
                            dataRow["Ref No./Cheque/n No."] = "IHJ8183460TRANSFER TO 62397292163";
                            //dataRow["Debit"] = Convert.ToString(i) + ".00";
                            //dataRow["Credit"] = Convert.ToString(i) + ".00";
                            //dataRow["Balance"] = Convert.ToString(i + 1000) + ".00";                               
                            if (chileNode.Attributes[2].Value.Equals("Debit"))
                            {
                                dataRow["Debit"] = Convert.ToString(chileNode.Attributes[3].Value) + ".00";
                                totalBalance -= Convert.ToInt32(chileNode.Attributes[3].Value);
                                //Minus from total
                            }
                            else if (chileNode.Attributes[2].Value.Equals("Credit"))
                            {
                                dataRow["Credit"] = Convert.ToString(chileNode.Attributes[3].Value) + ".00";
                                totalBalance += Convert.ToInt32(chileNode.Attributes[3].Value);
                            }
                            dataRow["Balance"] = Convert.ToString(totalBalance) + ".00";
                            tableData.Rows.Add(dataRow);
                        }
                        else if (value > 0)
                        {
                            return;
                        }

                    }
                }
                else
                {
                    //int month11 = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(month) + 2;
                    string dateInString = month + " " + day + "," + " " + year;
                    DateTime parsedDate = DateTime.Parse(dateInString);
                    int value = DateTime.Compare(parsedDate, toDate);
                    if (value <= 0)
                    {
                        DataRow dataRow = tableData.NewRow();
                        // Important you have create New row
                        dataRow["Txn Date"] = chileNode.Attributes[0].Value+" "+ month + " " +  year; //Convert.ToString(DateTime.Today);
                        dataRow["Value/nDate"] = chileNode.Attributes[0].Value+" "+month + " " +  year;// Convert.ToString(DateTime.Today);
                        dataRow["Description"] = Convert.ToString(chileNode.Attributes[1].Value);
                        dataRow["Ref No./Cheque/n No."] = "IHJ8183460TRANSFER TO 62397292163";
                        if (chileNode.Attributes[2].Value.Equals("Debit"))
                        {
                            dataRow["Debit"] = Convert.ToString(chileNode.Attributes[3].Value) + ".00";
                            totalBalance -= Convert.ToInt32(chileNode.Attributes[3].Value);
                            //Minus from total
                        }
                        else if (chileNode.Attributes[2].Value.Equals("Credit"))
                        {
                            dataRow["Credit"] = Convert.ToString(chileNode.Attributes[3].Value) + ".00";
                            totalBalance += Convert.ToInt32(chileNode.Attributes[3].Value);
                        }
                        dataRow["Balance"] = Convert.ToString(totalBalance) + ".00";
                        //dataRow["Debit"] = Convert.ToString(i) + ".00";
                        //dataRow["Credit"] = Convert.ToString(i) + ".00";
                        //dataRow["Balance"] = Convert.ToString(i + 1000) + ".00";
                        tableData.Rows.Add(dataRow);
                    }
                    else if (value > 0)
                    {
                        return;
                    }
                }

            }
            //}

            int lastDayOfMonth = DateTime.DaysInMonth(Convert.ToInt32(year), Convert.ToInt32(monthNumber));
            //dataRow["Debit"] = Convert.ToString(i) + ".00";
            //dataRow["Credit"] = Convert.ToString(i) + ".00";
            //dataRow["Balance"] = Convert.ToString(i + 1000) + ".00";
            //
            salary = Convert.ToInt32(ConfigurationManager.AppSettings["Salary"]);
            DataRow dataRowNew = tableData.NewRow();
            // Important you have create New row
            dataRowNew["Txn Date"] = lastDayOfMonth+" "+month + " " + year; //Convert.ToString(DateTime.Today);
            dataRowNew["Value/nDate"] = lastDayOfMonth+" "+month + " " + year;// Convert.ToString(DateTime.Today);
            dataRowNew["Description"] = Convert.ToString(ConfigurationManager.AppSettings["CompanyName"]);
            dataRowNew["Ref No./Cheque/n No."] = "IHJ8183460TRANSFER TO 62397292163";
            dataRowNew["Credit"] = Convert.ToString(salary) + ".00";
            totalBalance += Convert.ToInt32(salary);
            dataRowNew["Balance"] = Convert.ToString(totalBalance) + ".00";
            tableData.Rows.Add(dataRowNew);
            //}
            fromDate = fromDate.AddMonths(1);

            string sMonth = fromDate.ToString("MM");
            AddDataToTable(fromDate, toDate, xmlDoc, tableData, false, sMonth);
        }
    }
}


    


    


