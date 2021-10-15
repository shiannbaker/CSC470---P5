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
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
