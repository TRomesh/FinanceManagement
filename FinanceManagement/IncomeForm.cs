using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FinanceManagement
{
    public partial class IncomeForm : Form
    {
        private static readonly Object XmlLocker = new Object();
        private Thread workerThread = null;
        private bool stopProcess = false;
        private delegate void UpdateStatusDelegate();
        public event sendMessageIncome sendIncome;
        private ComboBox[] combo1;  // Array of comboboxes
        private RichTextBox[] rtext1;  // Array of richtextbo
        private TextBox[] text1;    // Array of textboxes
        private GroupBox[] groupBox; // Array of groupboxes
        private int count = 0;
        private int max_row = 5;
        private int top_row = 0;
        private int empty_count = 0;
        private string name = "";
        private int id = 0;
        List<Contact> contact;
        string filepath = Path.Combine(Environment.CurrentDirectory, "Income.xml");

        public IncomeForm()
        {
            InitializeComponent();
            combo1_rtext1_text1_array();    // declaring array for new row addition
        }

        public IncomeForm(string name, int id)
        {
            InitializeComponent();
            LoadContacts();
            this.name = name;
            this.id = id;
            combo1_rtext1_text1_array(); // declaring array for new row addition
        }

        public void LoadContacts()
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                this.contact = db.Contacts.ToList();
            }
        }

        public void WriteToXML(object param)
        {
            Income inc = (Income)param;

            lock (XmlLocker)
            {

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
                        xmlWriter.WriteElementString("Id", inc.Id.ToString());
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
                       new XElement("Id", inc.Id.ToString()),
                       new XElement("Amount", inc.Amount.ToString()),
                       new XElement("Contact", inc.Contact),
                       new XElement("Description", inc.Description),
                        new XElement("Datetime", inc.Datetime)
                     ));
                    xDocument.Save(filepath);
                    this.sendIncome(true);
                }
            }
        }


        private void combo1_rtext1_text1_array()
        {
            combo1 = new ComboBox[max_row];
            rtext1 = new RichTextBox[max_row];
            text1 = new TextBox[max_row];
            groupBox = new GroupBox[max_row];
            items_panel.AutoScroll = true;
            foreach (var cnt in contact)
            {
                contacts.Items.Add(cnt.Name);
            }

            if (File.Exists(filepath))
            {
                XDocument lbSrc = XDocument.Load(filepath);
                List<Income> ExpList = new List<Income>();

                foreach (XElement exp in lbSrc.Descendants("Income"))
                {
                    ExpList.Add(new Income
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
                    dataGridView1.DataSource = new BindingList<Income>(ExpList);
                }
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
                foreach (var cnt in contact)
                {
                    combo1[count].Items.Add(cnt.Name);
                }

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
            Income inc = null;

            if (count > 0)
            {
                if (amount.Text != "" || contacts.SelectedItem.ToString() != null || description.Text != "")
                {
                    inc = new Income();
                    inc.Id = new Random().Next(1, 10000);
                    inc.Amount = float.Parse(amount.Text.ToString());
                    inc.Contact = contacts.SelectedItem.ToString();
                    inc.Description = description.Text.ToString();
                    inc.Datetime = DateTime.Now.ToString("MM-dd-yyyy");
                    workerThread = new Thread(new ParameterizedThreadStart(WriteToXML));
                    workerThread.Start(inc);

                }
                for (int i = 0; i < count; i++)
                {
                    if (text1[count].Text == "" || text1[count].Text == null || combo1[count].SelectedItem == null || rtext1[count].Text == "" || rtext1[count].Text == null)
                    {
                        empty_count++;
                    }
                    if (text1[count].Text != "" || combo1[count].SelectedItem != null || rtext1[count].Text != "")
                    {
                        inc = new Income();
                        inc.Id = new Random().Next(1, 10000);
                        inc.Amount = float.Parse(text1[count].Text);
                        inc.Contact = combo1[count].SelectedItem.ToString();
                        inc.Description = rtext1[count].Text.ToString();
                        inc.Datetime = DateTime.Now.ToString("MM-dd-yyyy");
                        workerThread = new Thread(new ParameterizedThreadStart(WriteToXML));
                        workerThread.Start(inc);
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
                    inc = new Income();
                    inc.Id = new Random().Next(1, 10000);
                    inc.Amount = float.Parse(amount.Text.ToString());
                    inc.Contact = contacts.SelectedItem.ToString();
                    inc.Description = description.Text.ToString();
                    inc.Datetime = DateTime.Now.ToString("MM-dd-yyyy");
                    workerThread = new Thread(new ParameterizedThreadStart(WriteToXML));
                    workerThread.Start(inc);

                }
                else
                    MessageBox.Show("Empty Fields detected ! Please fill or select data for all fields");
            combo1_rtext1_text1_array();
        }

        private void save()
        {


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //delete();
            update();
        }

        public void delete()
        {
            lock (XmlLocker)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(filepath);
                foreach (XmlNode xNode in xDoc.SelectNodes("Incomes/Income"))
                    if (xNode.SelectSingleNode("Amount").InnerText == "101") xNode.ParentNode.RemoveChild(xNode);
                xDoc.Save(filepath);
            }
        }

        public void update()
        {
            lock (XmlLocker)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(filepath);
                foreach (XmlNode xNode in xDoc.SelectNodes("Incomes/Income"))
                    if (xNode.SelectSingleNode("Amount").InnerText == "111")
                    {
                        XmlDocument newxNode = new XmlDocument();
                        newxNode.CreateNode("Incomes/Income", "Amount", "222");
                        xNode.ParentNode.ReplaceChild(newxNode, xNode);
                    }

                xDoc.Save(filepath);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
