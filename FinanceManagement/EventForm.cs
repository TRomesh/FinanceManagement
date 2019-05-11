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
        Events events;
        Appointment app;
        Task tas;
        User user;

        public EventForm()
        {
            InitializeComponent();
        }

        public EventForm(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            getUser(this.id);
        }

        public void getUser(int id)
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                this.user = db.Users.First(u => u.Id == id);
            }
        }

        public void edidelbuttonApp()
        {
            btnupdateapp.Enabled = false;
            btndeleteapp.Enabled = false;
        }

        public void edidelbuttonTask()
        {
            btnupdateevn.Enabled = false;
            btndeleteevn.Enabled = false;
        }

        public void populateAppointments()
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                var contact = from p in db.Events.OfType<Appointment>()
                              select new
                              {
                                  Id = p.Id,
                                  Name = p.Name,
                                  Type = p.Type,
                                  Datetime = p.Datetime

                              };

                appointmentGridView.DataSource = contact.ToList();
                appointmentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void populateTasks()
        {
            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                var contact = from p in db.Events.OfType<Task>()
                              select new
                              {
                                  Id = p.Id,
                                  Name = p.Name,
                                  Type = p.Type,
                                  Datetime = p.Datetime,
                                  Reccuring = p.Reccuring

                              };

                taskGridView.DataSource = contact.ToList();
                taskGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void AppSave(object sender, EventArgs e)
        {
            //events = new Events();
            app = new Appointment();
            app.Name = apname.Text.Trim();
            app.Datetime = apdate.Text.Trim();
            app.Type = aptype.Text.Trim();
            app.Description = apdescription.Text.Trim();
            app.UserId = this.id;
            app.User = this.user;
            events = app;

            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                db.Events.Add(events);
                db.SaveChanges();
            }

            ClearApp();
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
            tas = new Task();
            tas.Name = taname.Text.Trim();
            tas.Datetime = tadate.Text.Trim();
            tas.Type = tatype.Text.Trim();
            tas.Description = tadescription.Text.Trim();
            tas.UserId = this.id;
            tas.Reccuring = true;

            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                db.Events.Add(tas);
                db.SaveChanges();
            }

            ClearTask();
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

        private void ClearTask()
        {
            taname.Text = tadescription.Text = tadate.Text = "";
            this.edidelbuttonTask();
        }

        private void ClearApp()
        {
            apname.Text = apdescription.Text = apdate.Text = "";
            this.edidelbuttonApp();
        }
    }
}
