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
    public partial class EventForm : Form
    {
        private string name = "";
        private int id = 0;

        public EventForm()
        {
            InitializeComponent();
        }

        public EventForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        public void edidelbuttonApp()
        {
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }

        public void edidelbuttonTask()
        {
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }

        public void populateAppointments()
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                var contact = from p in db.Contacts
                              select new
                              {
                                  Id = p.Id,
                                  Name = p.Name,
                                  Type = p.Type,
                                  Emal = p.Emal,

                              };

                appointmentGridView.DataSource = contact.ToList();
                appointmentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void populateTasks()
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                var contact = from p in db.Contacts
                              select new
                              {
                                  Id = p.Id,
                                  Name = p.Name,
                                  Type = p.Type,
                                  Emal = p.Emal,

                              };

                taskGridView.DataSource = contact.ToList();
                taskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ClearTask()
        {
            cemail.Text = cname.Text = ctype.Text = "";
            this.edidelbuttonTask();
        }

        private void ClearApp()
        {
            cemail.Text = cname.Text = ctype.Text = "";
            this.edidelbuttonApp();
        }

        private void AppSave(object sender, EventArgs e)
        {

        }

        private void AppCancel(object sender, EventArgs e)
        {

        }

        private void AppDelete(object sender, EventArgs e)
        {

        }

        private void AppUpdate(object sender, EventArgs e)
        {

        }

        private void TaskSave(object sender, EventArgs e)
        {

        }

        private void TaskCanvel(object sender, EventArgs e)
        {

        }

        private void TaskDelete(object sender, EventArgs e)
        {

        }

        private void TaskUpdate(object sender, EventArgs e)
        {

        }
    }
}
