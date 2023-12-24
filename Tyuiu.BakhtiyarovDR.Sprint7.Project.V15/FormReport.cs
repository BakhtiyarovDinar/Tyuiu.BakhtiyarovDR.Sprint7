using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BakhtiyarovDR.Sprint7.Project.V15
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void buttonBack_BDR_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Close();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartFunctions_BDR_Click(object sender, EventArgs e)
        {

        }
    }
}
