﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FinanceManagement
{
    public partial class ExpenseForm : Form
    {

        private ComboBox[] combo1;  // Array of comboboxes
        private RichTextBox[] rtext1;  // Array of richtextbo
        private TextBox[] text1;    // Array of textboxes
        private GroupBox[] groupBox; // Array of groupboxes
        List<Expense> list = null;
        private int count = 0;
        private int max_row = 5;
        private int top_row = 0;
        private int empty_count = 0;
        string filepath = Environment.CurrentDirectory + @"Expense.xml";
        public ExpenseForm()
        {
            InitializeComponent();
            combo1_rtext1_text1_array();    // declaring array for new row addition
        }

        public void WriteToXML(Expense exp)
        {
            if (!File.Exists(filepath))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(filepath, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Expenses");

                    xmlWriter.WriteStartElement("Expense");
                    xmlWriter.WriteElementString("Id", exp.Id.ToString());
                    xmlWriter.WriteElementString("Amount", exp.Amount.ToString());
                    xmlWriter.WriteElementString("Contact", exp.Contact);
                    xmlWriter.WriteElementString("Description", exp.Description);
                    xmlWriter.WriteElementString("Datetime", exp.Datetime);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(filepath);
                XElement root = xDocument.Element("Expenses");
                IEnumerable<XElement> rows = root.Descendants("Expense");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Expense",
                   new XElement("Id", exp.Id.ToString()),
                   new XElement("Amount", exp.Amount.ToString()),
                   new XElement("Contact", exp.Contact),
                   new XElement("Description", exp.Description),
                    new XElement("Datetime", exp.Datetime)
                   ));
                xDocument.Save(filepath);
            }

        }

        private void combo1_rtext1_text1_array()
        {
            combo1 = new ComboBox[max_row];
            rtext1 = new RichTextBox[max_row];
            text1 = new TextBox[max_row];
            groupBox = new GroupBox[max_row];
            items_panel.AutoScroll = true;
            for (int i = 1; i <= 5; i++)
                contacts.Items.Add("Item " + i);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Expense>));

            using (FileStream stream = File.OpenWrite(filepath))
            {
                list = new List<Expense>();
                serializer.Serialize(stream, list);
            }
            if (list != null)
            {
                dataGridView1.DataSource = new BindingList<Expense>(list);
            }
            

        }


        private void add_row_Click(object sender, EventArgs e)
        {
        if (count == max_row - 1)
        {
            MessageBox.Show("Maximum of 5 rows can be added");
            return;
        }
        else
        {
            count++;

            combo1[count] = new ComboBox();
            for (int i = 1; i <= 5; i++)
                combo1[count].Items.Add("Item " + i);
            rtext1[count] = new RichTextBox();
            text1[count] = new TextBox();
            groupBox[count] = new GroupBox();

            this.combo1[count].Location = new System.Drawing.Point(10, 20);
            this.combo1[count].Size = new System.Drawing.Size(150, 20);
            this.combo1[count].TabIndex = 1;

            this.text1[count].Location = new System.Drawing.Point(185, 20);
            this.text1[count].Size = new System.Drawing.Size(150, 20);
            this.text1[count].TabIndex = 2;

            this.rtext1[count].Location = new System.Drawing.Point(360, 20);
            this.rtext1[count].Size = new System.Drawing.Size(145, 20);
            this.rtext1[count].TabIndex = 3;

            this.groupBox[count].Controls.Add(this.combo1[count]);
            this.groupBox[count].Controls.Add(this.text1[count]);
            this.groupBox[count].Controls.Add(this.rtext1[count]);
            this.groupBox[count].Location = new System.Drawing.Point(10, top_row);
            this.groupBox[count].Size = new System.Drawing.Size(518, 56);
            this.groupBox[count].TabIndex = 7;
            this.groupBox[count].TabStop = false;

            this.items_panel.Controls.Add(groupBox[count]);
            top_row = 56 + top_row;
        }
    }

        private void remove_row_Click(object sender, EventArgs e)
        {
        if (count > -1)  // Deleting one row at a time
        {
            this.items_panel.Controls.Remove(combo1[count]);
            this.items_panel.Controls.Remove(rtext1[count]);
            this.items_panel.Controls.Remove(text1[count]);
            count--;
        }
    }

        private void reset_Click(object sender, EventArgs e)
        {
        amount.ResetText();
        contacts.ResetText();
        description.ResetText();
        for (int i = count; i > -1; i--)
        {
            this.items_panel.Controls.Remove(combo1[i]);
            this.items_panel.Controls.Remove(rtext1[i]);
            this.items_panel.Controls.Remove(text1[i]);
        }
        count = 0;
    }

        private void submit_Click(object sender, EventArgs e)
        {
        Expense exp = null;

        if (count > 0)
        {
            for (int i = 0; i <= count; i++)
            {
                if (text1[count].Text == "" || text1[count].Text == null || combo1[count].SelectedItem == null || rtext1[count].Text == "" || rtext1[count].Text == null)
                {
                    empty_count++;
                }
                if (text1[count].Text != "" || combo1[count].SelectedItem != null || rtext1[count].Text != "")
                {
                    exp = new Expense();
                    exp.Id = new Random().Next(1, 10000);
                    exp.Amount = float.Parse(text1[count].Text);
                    exp.Contact = combo1[count].SelectedItem.ToString();
                    exp.Description = rtext1[count].Text.ToString();
                    exp.Datetime = DateTime.Now.ToString("MM-dd-yyyy");
                    WriteToXML(exp);
                }

            }
            if (empty_count > 0)
            {
                MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
                empty_count = 0;
            }
        }
        else if (count == 0)
            if (amount.Text != "" || contacts.SelectedItem.ToString() != null || description.Text != "")
            {
                exp = new Expense();
                exp.Id = new Random().Next(1, 10000);
                exp.Amount = float.Parse(amount.Text.ToString());
                exp.Contact = contacts.SelectedItem.ToString();
                exp.Description = description.Text.ToString();
                exp.Datetime = DateTime.Now.ToString("MM-dd-yyyy");
                WriteToXML(exp);
            }
            else
                MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
    }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void AddExpenseLine(object sender, EventArgs e)
        {

        }
    }
}
