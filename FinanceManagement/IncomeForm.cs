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
using System.Xml.Serialization;

namespace FinanceManagement
{
    public partial class IncomeForm : Form
    {

        List<Income> intList = new List<Income> {
            new Income {Amount = 100, Contact = "abc", datetime = new DateTime()},
             new Income {Amount = 200, Contact = "abcd", datetime = new DateTime()},
             new Income {Amount = 300, Contact = "abcde", datetime = new DateTime()}
        };

        string filepath = Environment.CurrentDirectory + @"Income.xml";

        public IncomeForm()
        {
            InitializeComponent();

            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(intList.GetType());
                serializer.Serialize(fs, intList);
            }
        }
    }
}
