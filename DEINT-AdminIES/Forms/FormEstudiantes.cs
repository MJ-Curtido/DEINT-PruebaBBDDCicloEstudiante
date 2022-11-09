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

        public FormEstudiantes()
        {
            InitializeComponent();
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
            if (tbNombre.Text.Equals("") || tbApe1.Text.Equals("") || tbApe2.Text.Equals("") || tbCiclo.Text.Equals("") || tbCorreo.Text.Equals("") || imgaenByte == null)
            {

            }
        }
    }
}
