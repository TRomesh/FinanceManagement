﻿using System;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void Expense(object sender, EventArgs e)
        {
            ExpenseForm epxf = new ExpenseForm();
            epxf.Show();
        }

        private void Income(object sender, EventArgs e)
        {

                IncomeForm inxf = new IncomeForm();
                inxf.Show();
        }

        private void Contact(object sender, EventArgs e)
        {
            ContactForm cntf = new ContactForm();
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
    }
}
