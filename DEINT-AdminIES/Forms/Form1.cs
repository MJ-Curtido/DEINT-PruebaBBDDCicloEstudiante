using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_AdminIES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            FormCiclos form = new FormCiclos();

            form.ShowDialog();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FormEstudiantes form = new FormEstudiantes();

            form.ShowDialog();
        }
    }
}
