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
        public Project currentProject;

        public FormMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            AppUser user = new AppUser();   // Create a new user
            FormLogin loginPrompt = new FormLogin();
            DialogResult loginResult = DialogResult.OK;

            // Run loop until successful login or user exits the program
            do
            {
                loginResult = loginPrompt.ShowDialog();
                user = loginPrompt._User;
                if (user == null)
                {
                    user = new AppUser();
                    user.isAuthenticated = false;   // If the user wasn't real, this keeps the loop going
                }

            } while (!user.isAuthenticated && loginResult == DialogResult.OK);

            if (loginResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                //Project _project = new Project();

                //showing second form
                FormSelect select = new FormSelect();
                select.ShowDialog();

                this.initProject();
            }
        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing second form
            FormSelect select = new FormSelect();
            select.ShowDialog();

            this.initProject();

        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new Project and pass the projectRepo so that the create dialog can add new projects
            FormCreate create = new FormCreate();
            create.ShowDialog();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModify modifyForm = new FormModify();
            modifyForm.ShowDialog();
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemove removeForm = new FormRemove();
            removeForm.ShowDialog();
        }

        // Custom function to load up the project, for now just displays the name
        private void initProject()
        {
            this.Text = "Main - " + currentProject.Name;
        }
    }
}
