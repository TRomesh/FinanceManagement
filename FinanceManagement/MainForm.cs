using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class MainForm : Form
    {
        Timer t = new Timer();
        string name = "";
        int id = 0;

        public delegate void IncomeRecordEventHandler(object sender, EventArgs e);
        public event IncomeRecordEventHandler icomeRecord;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string name,int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            label3.Text = this.name;
        }

        void IncomeStatus(bool message)
        {
            if (message)
            {
                pictureBox2.Image = global::FinanceManagement.Properties.Resources.checkmark;
            }
        }

        void ExpenseStatus(bool message)
        {
            if (message)
            {
                pictureBox3.Image = global::FinanceManagement.Properties.Resources.checkmark;
            }
            
        }

        private void Expense(object sender, EventArgs e)
        {
            ExpenseForm epxf = new ExpenseForm(this.name,this.id);
            epxf.sendExpense += new sendMessageExpense(ExpenseStatus);
            
        epxf.Show();
        }

        private void Income(object sender, EventArgs e)
        {

            IncomeForm inxf = new IncomeForm(this.name, this.id);
            inxf.sendIncome += new sendMessageIncome(IncomeStatus);
            inxf.Show();
        }

        private void Contact(object sender, EventArgs e)
        {
            ContactForm cntf = new ContactForm(this.name, this.id);
            cntf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            label1.Text = time;
        }

        private void Event(object sender, EventArgs e)
        {
            EventForm evn = new EventForm(this.name, this.id);
            evn.Show();

        }

        private void Reports(object sender, EventArgs e)
        {
            ReportForm rep = new ReportForm(this.name, this.id);
            rep.Show();
        }

        private void Prediction(object sender, EventArgs e)
        {
            PredictionForm pre = new PredictionForm(this.name, this.id);
            pre.Show();
        }

        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Logout(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }
    }
}
