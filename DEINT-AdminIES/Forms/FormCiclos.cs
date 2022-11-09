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
        CicloDLL Ciclo;

        public FormCiclos()
        {
            InitializeComponent();

            Ciclo = new CicloDLL();
            gridView.DataSource = Ciclo.MostrarCiclos().Tables[0];
            tbId.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbNombreCiclo.Text, @"^[\w\s]+$"))
            {
                if (Ciclo.Agregar(tbNombreCiclo.Text))
                {
                    MessageBox.Show("Ciclo introducido correctamente.");

                    gridView.DataSource = Ciclo.MostrarCiclos().Tables[0];

                    tbNombreCiclo.Text = "";
                    tbId.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar.");
                }
            }
            else
            {
                MessageBox.Show("Debes introducir un nombre de ciclo para poder añadirlo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!tbId.Text.Equals(""))
            {
                if (Ciclo.Eliminar(tbId.Text.ToString()))
                {
                    tbId.Text = "";
                    tbNombreCiclo.Text = "";

                    gridView.DataSource = Ciclo.MostrarCiclos().Tables[0];

                    MessageBox.Show("Borrado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila para poder borrar.");
            }
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridView.RowCount - 1)
            {
                tbId.Text = gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbNombreCiclo.Text = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!tbId.Text.Equals(""))
            {
                if (Ciclo.Modificar(tbId.Text.ToString(), tbNombreCiclo.Text.ToString()))
                {
                    tbId.Text = "";
                    tbNombreCiclo.Text = "";

                    gridView.DataSource = Ciclo.MostrarCiclos().Tables[0];

                    MessageBox.Show("Modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar.");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila para poder modificarla.");
            }
        }
    }
}
