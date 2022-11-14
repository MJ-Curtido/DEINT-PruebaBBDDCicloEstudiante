using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_AdminIES.DLL
{
    internal class EstudianteDLL
    {
        Conexion conexion;
        public EstudianteDLL()
        {
            conexion = new Conexion();
        }

        public Boolean Agregar(String nombreEstudiante, String apellido1, String apellido2, String email, byte[] foto, String nombreCiclo)
        {
            conexion.EjecutarComandoSinRetorno($"INSERT INTO ESTUDIANTE(NOMBRE, APELLIDO1, APELLIDO2, EMAIL, FOTO) VALUES('{nombreEstudiante}', '{apellido1}', '{apellido2}', '{email}', '{foto}');");

            return conexion.EjecutarComandoSinRetorno($"INSERT INTO ALUMNO_CICLO(ID_ESTUDIANTE, ID_CICLO) VALUES(SELECT ID FROM ESTUDIANTE WHERE EMAIL = '{email}', SELECT ID FROM CICLO WHERE NOMBRE = '{nombreCiclo}');");
        }

        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CICLO");

            return conexion.EjecutarSentencia(sentencia);
        }
    }
}