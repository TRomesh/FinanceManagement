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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace FinanceManagement
{
    public partial class IncomeForm : Form
    {
        int cLeft = 1;
        private ComboBox[] combo1;  // Array of comboboxes
        private RichTextBox[] rtext1;  // Array of richtextbo
        private TextBox[] text1;    // Array of textboxes
        private int count = -1;
        private int max_row = 10;
        private int empty_count = 0;
        private int rowIndex = 0;
        bool newFile = false;
        Income inc;
        string filepath = Environment.CurrentDirectory + @"Income.xml";

        public IncomeForm()
        {
            InitializeComponent();
            combo1_rtext1_text1_array();    // declaring array for new row addition
        }

        public void WriteToXML()
        {

            inc = new Income { Id = 1, Amount = 100, Contact = "abc", Description = "hello", Datetime = DateTime.Today.ToString("dd/MM/yyyy") };

            if (!File.Exists(filepath))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(filepath, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Incomes");

                    xmlWriter.WriteStartElement("Income");
                    xmlWriter.WriteElementString("Amount", inc.Amount.ToString());
                    xmlWriter.WriteElementString("Contact", inc.Contact);
                    xmlWriter.WriteElementString("Description", inc.Description);
                    xmlWriter.WriteElementString("Datetime", inc.Datetime);
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
                XElement root = xDocument.Element("Incomes");
                IEnumerable<XElement> rows = root.Descendants("Income");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Income",
                   new XElement("Amount", inc.Amount.ToString()),
                   new XElement("Contact", inc.Contact),
                   new XElement("Description", inc.Description),
                    new XElement("Datetime", DateTime.Today.ToString("dd/MM/yyyy"))
                   ));
                xDocument.Save(filepath);
            }

        }


        private void combo1_rtext1_text1_array()
        {
            items_panel.HorizontalScroll.Enabled = false;
            combo1 = new ComboBox[max_row];
            rtext1 = new RichTextBox[max_row];
            text1 = new TextBox[max_row];
        }

        private void add_row_Click(object sender, EventArgs e)
        {
            if (count == max_row - 1)
            {
                MessageBox.Show("Maximum of 10 rows can be added");
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
                rowIndex = this.items_panel.RowCount++;
                combo1[count].Dock = DockStyle.Fill;
                rtext1[count].Dock = DockStyle.Fill;
                text1[count].Dock = DockStyle.Fill;
                this.items_panel.Dock = DockStyle.None;
                combo1[count].Anchor = AnchorStyles.None;
                rtext1[count].Anchor = AnchorStyles.None;
                text1[count].Anchor = AnchorStyles.None;
                this.items_panel.Controls.Add(this.combo1[count], 0, rowIndex);
                this.items_panel.Controls.Add(this.text1[count], 1, rowIndex);
                this.items_panel.Controls.Add(this.rtext1[count], 2, rowIndex);
                this.items_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                this.items_panel.AutoScroll = true;
                this.items_panel.HorizontalScroll.Visible = false;

                cLeft = cLeft + 1;
            }
        }

        private void remove_row_Click(object sender, EventArgs e)
        {
            if (count > -1)  // Deleting one row at a time
            {
                this.items_panel.Controls.Remove(combo1[count]);
                this.items_panel.Controls.Remove(rtext1[count]);
                this.items_panel.Controls.Remove(text1[count]);
                this.items_panel.RowCount--;  // decrementing the row count
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
            this.items_panel.RowCount = 1;
            count = -1;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (count > -1)
            {
                for (int i = 0; i <= count; i++)
                {
                    if (text1[count].Text == "" || combo1[count].SelectedItem == null || rtext1[count].Text == null)
                        empty_count++;
                }
                if (empty_count > 0)
                {
                    MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
                    empty_count = 0;
                }
                else
                    MessageBox.Show("No database connection for this application !!! ");
            }
            else if (count == -1)
                if (amount.Text == "" || contacts.SelectedItem == null || description.Text == "")
                    MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
                else
                    MessageBox.Show("No database connection for this application");
        }

        private void save()
        {
            inc = new Income { Id = 1, Amount = 100, Contact = "abc", Description = "hello", Datetime = DateTime.Today.ToString("dd/MM/yyyy") };

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(filepath);
            //dataGridView1.DataSource = dataSet.Tables[0];
            // WriteToXML();
            delete();
        }

        public void delete()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filepath);
            foreach (XmlNode xNode in xDoc.SelectNodes("Incomes/Income"))
                if (xNode.SelectSingleNode("Amount").InnerText == "101") xNode.ParentNode.RemoveChild(xNode);
            xDoc.Save(filepath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
