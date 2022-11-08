using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_AdminIES.Model
{
    internal class Estudiante
    {
        public int ID { get; set; }
        public String NombreEstudiante { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public int Ciclo { get; set; }
        public String Email { get; set; }
        public byte[] FotoEstudiante { get; set; }
    }
}