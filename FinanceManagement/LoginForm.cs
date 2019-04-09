using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinanceManagement.MD5;

namespace FinanceManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void Login(object sender, EventArgs e)
        {
            if (username.ToString().Trim() != "" || password.ToString().Trim() != "")
            {
                using (FinanceManagementEntities db = new FinanceManagementEntities())
                {
                    User user = db.Users.SqlQuery("Select * from Users where Username=@username and Password=@password", new[]{
                           new SqlParameter("@username", username.Text.ToString().Trim()),
                           new SqlParameter("@password", MD5Encrypt(password.Text.ToString().Trim()))
                        }).FirstOrDefault();
                    if (user != null)
                    {
                        MainForm main = new MainForm(user.Name,user.Id);
                        this.Hide();
                        main.Show();
              
                    }
                }
            }

        }

        private void Register(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
