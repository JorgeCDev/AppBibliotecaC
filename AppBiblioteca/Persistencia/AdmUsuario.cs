using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppBiblioteca.Persistencia
{
    class AdmUsuario
    {
        public static SqlException Errores;

        public List<string> ObtenerTipo(SqlConnection conexion)
        {
            List<string> tipo = new List<string>();
            string tipoUsuario = "";

            try
            {
                conexion.Open();
                string strCommando = "select * from TipoUsuario";
                SqlCommand comando = new SqlCommand(strCommando, conexion);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    tipoUsuario = datos["TipoUsuario"].ToString();
                    tipo.Add(tipoUsuario);
                }
                conexion.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }
            
            return tipo;                       
        }

        public List<string> ObtenerCiudad(SqlConnection conexion)
        {
            List<string> ciudad = new List<string>();
            string ciudadNombre = "";

            try
            {
                conexion.Open();
                string strCommando = "select * from Ciudad";
                SqlCommand comando = new SqlCommand(strCommando, conexion);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    ciudadNombre = datos["Ciudad"].ToString();
                    ciudad.Add(ciudadNombre);
                }
                conexion.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            return ciudad;
        }

        public bool AgregaUsuario(SqlConnection conexion, string nombre, string apePat, string apeMat, int ciudad, int tipo)
        {
            bool agregado = false;

            try
            {
                conexion.Open();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            string strComando = "EXEC SP_AGREGA_USUARIO @NOMBRE, @APEPAT, @APEMAT, @CIUDADID, @TIPOID";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            comando.Parameters.AddWithValue("@NOMBRE", nombre);
            comando.Parameters.AddWithValue("@APEPAT", apePat);
            comando.Parameters.AddWithValue("@APEMAT", apeMat);
            comando.Parameters.AddWithValue("@CIUDADID", ciudad);
            comando.Parameters.AddWithValue("@TIPOID", tipo);

            try
            {
                comando.ExecuteNonQuery();
                agregado = true;
            }
            catch (SqlException ex)
            {
                Errores = ex;
                conexion.Close();
            }
            conexion.Close();

            return agregado;
        }

        public DataTable ObtenerTabla(SqlConnection conexion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("EXEC SP_USUARIOS_DATOS", conexion);

            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtbuscar = new DataTable();
            da.Fill(dtbuscar);
            conexion.Close();

            return dtbuscar;
        }

    }
}
