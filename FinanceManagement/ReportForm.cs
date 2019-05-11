using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FinanceManagement.Properties;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FinanceManagement
{
    public partial class ReportForm : Form
    {
        private string name = "";
        private int id = 0;
        string filepath = Path.Combine(Environment.CurrentDirectory, "Report_" + DateTime.Now.ToString("MM-dd-yyyy") + ".pdf");
        List<Income> IncList;
        List<Expense> ExpList;
        List<Income> income;
        List<Expense> expense;
        string incomefilepath = Path.Combine(Environment.CurrentDirectory, "Income.xml");
        string expensefilepath = Path.Combine(Environment.CurrentDirectory, "Expense.xml");

        public ReportForm()
        {
            InitializeComponent();
            LoadMXL();
        }

        public ReportForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            LoadMXL();
        }

        public void LoadMXL()
        {
            comboBox1.Items.Add("Weekly");
            if (File.Exists(incomefilepath))
            {
                XDocument lbSrc = XDocument.Load(incomefilepath);
                 IncList = new List<Income>();

                foreach (XElement exp in lbSrc.Descendants("Income"))
                {
                    IncList.Add(new Income
                    {
                        Id = int.Parse(exp.Element("Id").Value),
                        Amount = float.Parse(exp.Element("Amount").Value),
                        Contact = exp.Element("Contact").Value,
                        Description = exp.Element("Description").Value,
                        Datetime = exp.Element("Datetime").Value
                    });
                }

                if (IncList != null)
                {
                    IEnumerable<Income> result = IncList.Where(item => item.Datetime == DateTime.Now.ToString("MM-dd-yyyy"));
                    income = result.ToList();
                }

            }

            if (File.Exists(expensefilepath))
            {
                XDocument lbSrc = XDocument.Load(expensefilepath);
                 ExpList = new List<Expense>();

                foreach (XElement exp in lbSrc.Descendants("Expense"))
                {
                    ExpList.Add(new Expense
                    {
                        Id = int.Parse(exp.Element("Id").Value),
                        Amount = float.Parse(exp.Element("Amount").Value),
                        Contact = exp.Element("Contact").Value,
                        Description = exp.Element("Description").Value,
                        Datetime = exp.Element("Datetime").Value
                    });
                }

                if (ExpList != null)
                {
                    IEnumerable<Expense> result = ExpList.Where(item => item.Datetime == DateTime.Now.ToString("MM-dd-yyyy"));
                    expense = result.ToList();
                }

            }
        }

        public void GeneratePDF()
        {
            Document doc = new Document(PageSize.A4);
            var output = new FileStream(filepath, FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);


            doc.Open();

            PdfPTable table1 = new PdfPTable(2);
            table1.DefaultCell.Border = 0;
            table1.WidthPercentage = 80;


            PdfPCell cell11 = new PdfPCell();
            cell11.Colspan = 1;

            cell11.AddElement(new Paragraph("Income & Expense Report"));


            cell11.VerticalAlignment = Element.ALIGN_LEFT;

            PdfPCell cell12 = new PdfPCell();


            cell12.VerticalAlignment = Element.ALIGN_CENTER;


            table1.AddCell(cell11);

            table1.AddCell(cell12);


            PdfPTable table2 = new PdfPTable(5);

            //One row added

            PdfPCell cell19 = new PdfPCell();

            cell19.AddElement(new Paragraph("Description"));

            PdfPCell cell20 = new PdfPCell();

            cell20.AddElement(new Paragraph("Datetime"));

            PdfPCell cell21 = new PdfPCell();

            cell21.AddElement(new Paragraph("Income/Expense"));

            PdfPCell cell22 = new PdfPCell();

            cell22.AddElement(new Paragraph("Contact"));

            PdfPCell cell23 = new PdfPCell();

            cell23.AddElement(new Paragraph("Amount"));

            table2.AddCell(cell19);

            table2.AddCell(cell20);

            table2.AddCell(cell21);

            table2.AddCell(cell22);

            table2.AddCell(cell23);


            //New Row Added

            foreach (var income in IncList)
            {

                PdfPCell cell31 = new PdfPCell();

                cell31.AddElement(new Paragraph(income.Description));



                PdfPCell cell32 = new PdfPCell();

                cell32.AddElement(new Paragraph(income.Datetime));

       

                PdfPCell cell33 = new PdfPCell();

                cell33.AddElement(new Paragraph("Income"));



                PdfPCell cell34 = new PdfPCell();

                cell34.AddElement(new Paragraph(income.Contact));

                

                PdfPCell cell35 = new PdfPCell();

                cell35.AddElement(new Paragraph(income.Amount.ToString()));

               

                table2.AddCell(cell31);
                table2.AddCell(cell32);
                table2.AddCell(cell33);
                table2.AddCell(cell34);
                table2.AddCell(cell35);

            }

            foreach (var expense in ExpList)
            {

                PdfPCell cell41 = new PdfPCell();

                cell41.AddElement(new Paragraph(expense.Description));



                PdfPCell cell42 = new PdfPCell();

                cell42.AddElement(new Paragraph(expense.Datetime));



                PdfPCell cell43 = new PdfPCell();

                cell43.AddElement(new Paragraph("Expense"));



                PdfPCell cell44 = new PdfPCell();

                cell44.AddElement(new Paragraph(expense.Contact));



                PdfPCell cell45 = new PdfPCell();

                cell45.AddElement(new Paragraph(expense.Amount.ToString()));



                table2.AddCell(cell41);
                table2.AddCell(cell42);
                table2.AddCell(cell43);
                table2.AddCell(cell44);
                table2.AddCell(cell45);

            }



            PdfPCell cell2A = new PdfPCell(table2);

            cell2A.Colspan = 2;

            table1.AddCell(cell2A);

            PdfPCell cell51 = new PdfPCell();

            cell51.AddElement(new Paragraph("Name : " + this.name));

            cell51.VerticalAlignment = Element.ALIGN_LEFT;

            PdfPCell cell52 = new PdfPCell();

            cell52.AddElement(new Paragraph("Balance : " + "3993"));

            cell52.VerticalAlignment = Element.ALIGN_RIGHT;


            table1.AddCell(cell51);

            table1.AddCell(cell52);


            doc.Add(table1);

            doc.Close();
        }

        private void GeneratePDF(object sender, EventArgs e)
        {
            GeneratePDF();
        }
    }
}
