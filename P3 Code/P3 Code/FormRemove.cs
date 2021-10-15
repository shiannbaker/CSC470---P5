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
    public partial class FormRemove : Form
    {
        public Project currentProject;
        public FormRemove()
        {
            InitializeComponent();
        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            FormSelect form = new FormSelect(2);    // 2 is code for remove
            form.ShowDialog();

            if (form.DialogResult != DialogResult.OK)
            {
                this.Close();
            }

            labelProject.Text = "Project to remove: " + currentProject.Name;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FakeProjectRepository projectRepo = new FakeProjectRepository();
            List<Project> projects = projectRepo.GetAll();

            string name = currentProject.Name;

            // NOT TO CONFUSE THIS FORM'S currentProject with the MainForm's
            Project a = projects.FirstOrDefault(x => x.Name == currentProject.Name);

            FormMain var = (FormMain)Application.OpenForms["FormMain"];
            if (a.Equals(var.currentProject))
            {
                MessageBox.Show("Cannot modify your current session project.");
                this.Close();
            }
            else
            {
                DialogResult choice = MessageBox.Show("Are you sure you want to remove the project: " + currentProject.Name + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    string returnMessage = projectRepo.Remove(a.Id);
                    if (returnMessage.Equals("No Error."))
                    {
                        MessageBox.Show("Deleted project \"" + a.Name + "\".");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(returnMessage);
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
