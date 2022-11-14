using DEINT_AdminIES.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_AdminIES
{
    public partial class FormEstudiantes : Form
    {
        private byte[] imgaenByte;
        private EstudianteDLL estudiante;

        public FormEstudiantes()
        {
            InitializeComponent();

            estudiante = new EstudianteDLL();

            DataSet ds = estudiante.MostrarCiclos();

            cbCiclos.ValueMember = "ID";
            cbCiclos.DisplayMember = "NOMBRE";
            cbCiclos.DataSource = ds.Tables[0];

            cbCiclos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                imgEstudiante.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoryStream = new MemoryStream();
                imgEstudiante.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imgaenByte = memoryStream.ToArray();


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals("") || tbApe1.Text.Equals("") || tbApe2.Text.Equals("") || tbCorreo.Text.Equals("") || imgaenByte == null)
            {
                MessageBox.Show("Debe introducir todos los campos.");
            }
            else
            {
                if (estudiante.Agregar(tbNombre.Text, tbApe1.Text, tbApe2.Text, tbCorreo.Text, imgaenByte, cbCiclos.Text))
                {
                    MessageBox.Show("Estudiante agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el estudiante.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
