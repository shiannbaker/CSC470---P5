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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakeProjectRepository var = new FakeProjectRepository();
            Project _project = new Project();
            string result = var.Add(_project, textBox1.Text);

            if(result == "No Error.")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
