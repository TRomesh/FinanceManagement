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

namespace FinanceManagement
{
    public partial class PredictionForm : Form
    {
        private string name = "";
        private int id = 0;
        List<Income> income;
        List<Expense> expense;
        string incomefilepath = Environment.CurrentDirectory + @"Income.xml";
        string expensefilepath = Environment.CurrentDirectory + @"Expense.xml";

        public PredictionForm()
        {
            InitializeComponent();
            LoadXML();
        }

        public PredictionForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            LoadXML();
        }

        public void LoadXML()
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
            LoadChart();
        }

        public void LoadChart()
        {
            this.chart1.Series["Profit"].Points.AddXY("Monday",10);
            this.chart1.Series["Profit"].Points.AddXY("Tuesday", 10);
            this.chart1.Series["Profit"].Points.AddXY("Wednesday", 10);
            this.chart1.Series["Profit"].Points.AddXY("Thursday", 10);
            this.chart1.Series["Profit"].Points.AddXY("Friday", 10);

        }
    }
}
