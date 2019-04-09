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
        string filepath = Environment.CurrentDirectory + @"Income_"+ DateTime.Now.ToString("MM-dd-yyyy") + ".pdf";
        List<Income> income;
        List<Expense> expense;
        string incomefilepath = Environment.CurrentDirectory + @"Income.xml";
        string expensefilepath = Environment.CurrentDirectory + @"Expense.xml";'

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        public void LoadMXL()
        {
            if (File.Exists(incomefilepath))
            {
                XDocument lbSrc = XDocument.Load(incomefilepath);
                List<Income> IncList = new List<Income>();

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
                List<Expense> ExpList = new List<Expense>();

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

            PdfPCell cell31 = new PdfPCell();

            cell31.AddElement(new Paragraph("Safe"));

            cell31.FixedHeight = 300.0f;

            PdfPCell cell32 = new PdfPCell();

            cell32.AddElement(new Paragraph("2"));

            cell32.FixedHeight = 300.0f;

            PdfPCell cell33 = new PdfPCell();

            cell33.AddElement(new Paragraph("20.00 * " + "2" + " = " + (20 * Convert.ToInt32("2")) + ".00"));

            cell33.FixedHeight = 300.0f;

            table2.AddCell(cell31);

            table2.AddCell(cell32);

            table2.AddCell(cell31);

            table2.AddCell(cell32);

            table2.AddCell(cell33);


            PdfPCell cell2A = new PdfPCell(table2);

            cell2A.Colspan = 2;

            table1.AddCell(cell2A);

            PdfPCell cell41 = new PdfPCell();

            cell41.AddElement(new Paragraph("Name : " + this.name));

            cell41.VerticalAlignment = Element.ALIGN_LEFT;

            PdfPCell cell42 = new PdfPCell();

            cell42.AddElement(new Paragraph("Balance : " + "3993"));

            cell42.VerticalAlignment = Element.ALIGN_RIGHT;


            table1.AddCell(cell41);

            table1.AddCell(cell42);


            doc.Add(table1);

            doc.Close();
        }

        private void GeneratePDF(object sender, EventArgs e)
        {
            GeneratePDF();
        }
    }
}
