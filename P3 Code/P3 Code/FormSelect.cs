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
        private int senderId;
        public FormSelect(int id)
        {
            senderId = id;
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

            List<Project> projects = projectRepo.GetAll();

            

            if (listBox1.SelectedIndex != -1)
            {

                // Set the correct variable from the caller forms's id
                // 1=main, 2=remove, 3=modify

                if (senderId == 1)
                {
                    FormMain var = (FormMain)Application.OpenForms["FormMain"];
                    var.currentProject = projects.FirstOrDefault(x => x.Id == int.Parse(listBox1.SelectedItem.ToString().Split('-')[0]));
                    this.Close();
                }
                else if (senderId == 2)
                {
                    FormRemove var = (FormRemove)Application.OpenForms["FormRemove"];
                    var.currentProject = projects.FirstOrDefault(x => x.Id == int.Parse(listBox1.SelectedItem.ToString().Split('-')[0]));
                    this.Close();
                }
                else if (senderId == 3)
                {
                    FormModify var = (FormModify)Application.OpenForms["FormModify"];
                    var.currentProject = projects.FirstOrDefault(x => x.Id == int.Parse(listBox1.SelectedItem.ToString().Split('-')[0]));
                    this.Close();
                }
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
                    var mainForm = (FormMain)Application.OpenForms["FormMain"];
                    mainForm.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
