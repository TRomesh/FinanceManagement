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
    public partial class ReportForm : Form
    {
        private string name = "";
        private int id = 0;

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
    }
}
