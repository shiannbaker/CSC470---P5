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
    public partial class FormModify : Form
    {
        public Project currentProject;
        public FormModify()
        {
            InitializeComponent();
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            FormSelect form = new FormSelect(3);
            form.ShowDialog();

            textBoxRename.Text = currentProject.Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FakeProjectRepository projectRepo = new FakeProjectRepository();
            List<Project> projects = projectRepo.GetAll();

            string text = textBoxRename.Text;
            string result = text.Trim();

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
                if (result == null || result == "")
                {
                    MessageBox.Show("Project name is empty or blank.");
                    
                }
                else
                {
                    Project b = projects.FirstOrDefault(x => x.Name == result);
                    if (b == default)
                    {
                        MessageBox.Show("Renamed project \"" + a.Name + "\" to \"" + result + "\".");
                        a.Name = result;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Project name already exists.");
                    }

                }
            }
        }
    }
}
