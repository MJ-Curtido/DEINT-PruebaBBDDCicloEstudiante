using DEINT_AdminIES.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_AdminIES
{
    public partial class FormCiclos : Form
    {
        public FormCiclos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbNombreCiclo.Text, @""))
            {
                CicloDLL cicloDLL = new CicloDLL();
                cicloDLL.Agregar(tbNombreCiclo.Text);
                MessageBox.Show("Ciclo introducido correctamente.");
                tbNombreCiclo.Text = "";
            }
            else
            {
                MessageBox.Show("Debes introducir un nombre de ciclo para poder añadirlo.");
            }
        }
    }
}
