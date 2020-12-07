using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppBiblioteca.Modelo;

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

        public DataTable ObtenerTablaMorosos(SqlConnection conexion)
        {


            conexion.Open();
            SqlCommand cmd = new SqlCommand("select UsuarioID,Nombre,ApePaterno,ApeMaterno,CiudadID,TipoUsuarioID,Moroso from Usuario WHERE Moroso=1 ", conexion);

            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtMorosos = new DataTable();
            da.Fill(dtMorosos);
            conexion.Close();
            dtMorosos.Columns["UsuarioID"].ColumnName = "ID";
            dtMorosos.Columns["ApePaterno"].ColumnName = "Paterno";
            dtMorosos.Columns["ApeMaterno"].ColumnName = "Materno";
            dtMorosos.Columns["CiudadID"].ColumnName = "ID Ciudad";
            dtMorosos.Columns["TipoUsuarioID"].ColumnName = "Tipo";



            return dtMorosos;
        }

        public void UpdateMoroso(string usuario,SqlConnection con)
        {
            int bit = 0;
            
            string query ="update Usuario set Moroso = @mora where UsuarioID ="+usuario;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mora", bit);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
               
            }
            catch(SqlException ex)
            {
                Errores = ex;
                con.Close();
            }
            con.Close();


        }

        public string NombreUsuario(string id, SqlConnection con)
        {

            string strComando = "SELECT Nombre+' '+ApePaterno+' '+ApeMaterno FROM Usuario WHERE UsuarioID = " + id;
            con.Open();
            SqlCommand comando = new SqlCommand(strComando, con);
            string Nombre = comando.ExecuteScalar().ToString();
            con.Close();

            return Nombre;
        }

        public bool isMoroso(string id, SqlConnection con)
        {

            string strComando = "SELECT Moroso FROM Usuario WHERE UsuarioID = " + id;
            con.Open();
            SqlCommand comando = new SqlCommand(strComando, con);
            string bit = comando.ExecuteScalar().ToString();
            con.Close();

            return bit.Equals("1") ? true:false;
        }

        public Usuario GetUsuario(string id,SqlConnection con)
        {

            Usuario user = new Usuario();
            string query = "select UsuarioID,Nombre,ApePaterno,ApeMaterno,CiudadID,TipoUsuarioID,Moroso from Usuario WHERE UsuarioID = " + id;
  
            try
            {
                con.Open();
        
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    user.ID = Convert.ToInt32( datos["UsuarioID"]);
                    user.Nom = datos["Nombre"].ToString();
                    user.Paterno = datos["ApePaterno"].ToString();
                    user.Materno = datos["ApeMaterno"].ToString();
                    user.Ciudad = Convert.ToInt32(datos["CiudadID"].ToString());
                    user.TipoUsuario = Convert.ToInt32(datos["TipoUsuarioID"].ToString());
                    user.Mora = Convert.ToBoolean(datos["Moroso"]);

                }
                con.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                con.Close();
            }

            return user;
                
        }

      

    }
}
