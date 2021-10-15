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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
        }
    }
}
