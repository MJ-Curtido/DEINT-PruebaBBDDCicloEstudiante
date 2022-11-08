using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_AdminIES.DLL
{
    internal class Conexion
    {
        private string cadenaConexion = "Data Source=DESKTOP-TI4PMR8; Initial Catalog=PruebaServidor; Integrated Security = True";

        SqlConnection conexion;

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
            
            return this.conexion;
        }

        public Boolean EjecutarComandoSinRetorno(String comando)
        {
            try
            {
                SqlCommand consulta = new SqlCommand();
                consulta.CommandText = comando;

                consulta.Connection = this.EstablecerConexion();
                conexion.Open();

                consulta.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia (SqlCommand consulta)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                consulta.Connection = this.EstablecerConexion();
                adapter.SelectCommand = consulta;
                conexion.Open();
                adapter.Fill(ds);
                conexion.Close();

                return ds;
            }
            catch (Exception e)
            {
                return ds;
            }

            
        }
    }
}