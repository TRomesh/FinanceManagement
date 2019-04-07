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
    }
}
