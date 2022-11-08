using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_AdminIES.DLL
{
    internal class CicloDLL
    {
        Conexion conexion;

        public CicloDLL()
        {
            conexion = new Conexion();
        }

        public Boolean Agregar(String nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetorno($"INSERT INTO CICLO(NOMBRE) VALUES('{nombreCiclo}');");
        }

        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CICLO");

            return conexion.EjecutarSentencia(sentencia);
        }
    }
}