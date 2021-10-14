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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            FakeProjectRepository project = new FakeProjectRepository();


            //print out each project
            listBox1.Items.Add("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form cancelled
            this.Close();

            FormMain var = (FormMain)Application.OpenForms["FormMain"];
            var.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select project
            //grab the name to display in MainForm

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
