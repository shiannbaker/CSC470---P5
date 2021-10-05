using System;
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
    public partial class FormMain : Form
    {
        // Variable to store out current user data
        public AppUser currentUser;

        public FormMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //this.Hide();

            AppUser user = new AppUser();

            FormLogin loginPrompt = new FormLogin();

            DialogResult retryResult = DialogResult.OK;
            do
            {
                retryResult = loginPrompt.ShowDialog();
                user = loginPrompt._User;
                if (user == null)
                {
                    user = new AppUser();
                    user.isAuthenticated = false;
                }

            } while (!user.isAuthenticated && retryResult == DialogResult.OK);

            if (retryResult != DialogResult.OK)
            {
                Console.Write("lol");
                this.Close();
            }
            else
            {
                this.Text = "Main - No Project Selected";
            }
            //this.Show();
        }
    }
}
