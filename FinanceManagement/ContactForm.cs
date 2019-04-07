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
    public partial class ContactForm : Form
    {

        Contact contact;
        int SelectedId = 0;
        FinanceManagementEntities db;

        public ContactForm()
        {
            InitializeComponent();
            populateContacts();
        }

        public void populateContacts()
        {
            using (db = new FinanceManagementEntities())
            {
                var contact = from p in db.Contacts
                              select new
                              {
                                  Id = p.Id,
                                  Name = p.Name,
                                  Type = p.Type,
                                  Emal = p.Emal,
                                  
                              };

                contactGridView.DataSource = contact.ToList();
                contactGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        

        private void Save(object sender, EventArgs e)
        {
            contact = new Contact();
            contact.Name = cname.Text.Trim();
            contact.Emal = cemail.Text.Trim();
            contact.Type = ctype.Text.Trim();
            contact.UserId = 1;

            using (db = new FinanceManagementEntities())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
            }

            Clear();

        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            cemail.Text = cname.Text = ctype.Text = "";
        }

        private void DoubleClickContact(object sender, EventArgs e)
        {
            if (contactGridView.CurrentRow.Index != -1)
            {
                contact = new Contact();
                contact.Id = this.SelectedId = Int32.Parse(contactGridView.CurrentRow.Cells[0].Value.ToString());

                using (FinanceManagementEntities db = new FinanceManagementEntities())
                {
                    contact = db.Contacts.Where(x => x.Id == contact.Id).FirstOrDefault();
                    cname.Text = contact.Name;
                    cemail.Text = contact.Emal;
                    ctype.Text = contact.Type;
                }
            }
        }
    }
}
