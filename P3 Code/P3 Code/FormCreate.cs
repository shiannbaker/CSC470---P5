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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FakeProjectRepository var = new FakeProjectRepository();

            Project _project = new Project();
            string result = var.Add(_project, textBox1.Text.Trim());

            if(result == "No Error.")
            {
                MessageBox.Show("Project \"" + textBox1.Text.Trim() + "\" added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {

        }
    }
}
