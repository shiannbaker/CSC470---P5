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
    public partial class FormSelect : Form
    {
        public FakeProjectRepository projectRepo = new FakeProjectRepository();
        public FormSelect()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            // show each project in the listBox
            List<Project> projects = projectRepo.GetAll();
            foreach (Project i  in projects)
            {
                listBox1.Items.Add(i.Id + " - " + i.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //have the user try again
            //show message that they should try again
            string message = "A project must be selected.";
            string title = "Attention";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Cancel)
            {
                //form cancelled
                this.Close();

                FormMain var = (FormMain)Application.OpenForms["FormMain"];
                var.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select project
            //grab the name to display in MainForm
            FormMain var = (FormMain)Application.OpenForms["FormMain"];
            List<Project> projects = projectRepo.GetAll();

            if (listBox1.SelectedIndex != -1)
            {
                var.currentProject = projects.FirstOrDefault(x => x.Id == int.Parse(listBox1.SelectedItem.ToString().Split('-')[0]));
                this.Close();
            }
            else
            {
                //have the user try again
                //show message that they should try again
                string message = "A project must be selected.";
                string title = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Cancel)
                {
                    //form cancelled
                    this.Close();
                    var.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
