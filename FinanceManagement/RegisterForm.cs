﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinanceManagement.MD5;

namespace FinanceManagement
{
    public partial class RegisterForm : Form
    {
       // private static RegisterForm registerForm = null;
        User newuser = new User();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register(object sender, EventArgs e)
        {
            newuser.Name = name.Text.Trim();
            newuser.Username = username.Text.Trim();
            newuser.Email = email.Text.Trim();
            newuser.Phone = phone.Text.Trim();
            newuser.Password = MD5Encrypt(password.Text.Trim());

            using (FinanceManagementEntities db = new FinanceManagementEntities())
            {
                db.Users.Add(newuser);
                db.SaveChanges();
            }

            Clear();
        }

        private void Cancel(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            name.Text = username.Text = email.Text = phone.Text = password.Text = "";
        }

    }
}
