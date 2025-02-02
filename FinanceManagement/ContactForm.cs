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
    public partial class ContactForm : Form
    {
        private string name = "";
        private int id = 0;
        Contact contact;
        int SelectedId = 0;
        FinanceManagementEntities db;

        public ContactForm()
        {
            InitializeComponent();
            populateContacts();
            edidelbutton();
        }

        public ContactForm(string name, int id)
        {
            InitializeComponent();
            populateContacts();
            edidelbutton();
            this.name = name;
            this.id = id;
        }

        public void edidelbutton()
        {
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
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
            contact.UserId = this.id;

            using (db = new FinanceManagementEntities())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
            populateContacts();
            Clear();

        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            cemail.Text = cname.Text = ctype.Text = "";
            this.edidelbutton();
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
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                contact = new Contact();
                contact.UserId = 1;
                contact.Id = SelectedId;
                contact.Name = cname.Text;
                contact.Emal = cemail.Text;
                contact.Type = ctype.Text;
                db.Entry(contact).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            this.Clear();
            this.populateContacts();

        }

        private void Delete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?","Delete",MessageBoxButtons.YesNo)== DialogResult.Yes);
            {
                using (FinanceManagementEntities db = new FinanceManagementEntities())
                {

                    cname.Text = contact.Name;
                    cemail.Text = contact.Emal;
                    ctype.Text = contact.Type;
                }
            }
            
        }
    }
}
