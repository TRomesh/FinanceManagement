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
    public partial class PredictionForm : Form
    {
        private string name = "";
        private int id = 0;

        public PredictionForm()
        {
            InitializeComponent();
        }

        public PredictionForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        public void LoadXML()
        {
            
        }
    }
}
