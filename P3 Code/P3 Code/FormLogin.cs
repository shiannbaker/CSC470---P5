﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string UserName = usernameBox.Text;
            string Password = passwordBox.Text;
            bool result;

            //check to see if they match
            FakeAppUserRepository login = new FakeAppUserRepository();
            result = login.Login(UserName, Password);

            if(result == false)
            {
                //have the user try again
                //show message that they should try again
                string message = "Authentication failed. Try again.";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result2 = MessageBox.Show(message, title, buttons);
                if (result2 == DialogResult.No)
                {
                    this.Close();
                }
            }
            else //result == true and window from should appear
            {
                
                this.Close();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}