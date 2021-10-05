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
            this.Hide();

            AppUser currentUser = new AppUser();

            FormLogin loginPrompt = new FormLogin();

            while (!currentUser.isAuthenticated)
            {
                loginPrompt.ShowDialog();
            }
        }
    }
}
