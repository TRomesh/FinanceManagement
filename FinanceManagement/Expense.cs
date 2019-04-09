﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagement
{
    public class Expense
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Contact { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
    }
}
