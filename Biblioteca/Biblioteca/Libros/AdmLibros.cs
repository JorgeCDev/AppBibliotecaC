using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Libros
{
    class AdmLibros
    {
        public static SqlException Errores;

        public List<string> ObtenerEditorial(SqlConnection conexion)
        {
            List<string> Editorial = new List<string>();
            string editorialNombre = "";

            try
            {                
                conexion.Open();
                string strCommando = "select * from Editorial";
                SqlCommand comando = new SqlCommand(strCommando, conexion);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    editorialNombre = datos["Editorial"].ToString();
                    Editorial.Add(editorialNombre);
                }
                conexion.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            return Editorial;
        }

        public List<string> TodosID(SqlConnection conexion)
        {
            List<string> IDs = new List<string>();
            string ID = "";

            try
            {
                conexion.Open();
                string strCommando = "select LibroID from Libro";
                SqlCommand comando = new SqlCommand(strCommando, conexion);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    ID = datos["LibroID"].ToString();
                    IDs.Add(ID);
                }
                conexion.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            return IDs;
        }

        public List<string> TodosNombres(SqlConnection conexion)
        {
            List<string> Nombres = new List<string>();
            string nombre = "";

            try
            {
                conexion.Open();
                string strCommando = "select Libro from Libro";
                SqlCommand comando = new SqlCommand(strCommando, conexion);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    nombre = datos["Libro"].ToString();
                    Nombres.Add(nombre);
                }
                conexion.Close();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            return Nombres;
        }

        public string ObtenerElNombre(SqlConnection conexion, string clave)
        {
            conexion.Open();            
            string strComando = "SELECT LIBRO FROM Libro WHERE LibroID = "+clave;
            SqlCommand comando = new SqlCommand(strComando, conexion);
            string Nombre = comando.ExecuteScalar().ToString();
            conexion.Close();

            return Nombre;
        }

        public string ObtenerElID(SqlConnection conexion, string nombre)
        {
            conexion.Open();
            string strComando = "SELECT LIBROID FROM Libro WHERE Libro = @NOMBRE ";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            comando.Parameters.AddWithValue("@NOMBRE", nombre);
            string ID = comando.ExecuteScalar().ToString();
            conexion.Close();

            return ID;
        }

        public int ObtenerID(SqlConnection conexion)
        {
            conexion.Open();

            string strComando = "SELECT COUNT(*) FROM Libro";
            SqlCommand comando = new SqlCommand(strComando, conexion);

            int ID = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();

            return ID;
        }

        public bool AgregaLibro(SqlConnection conexion, string nombre, int editor, string fecha, int cantidad, string autor)
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

            string strComando = "EXEC SP_AGREGA_LIBRO @NOMBRE, @EDITOR, @FECHA, @CANTIDAD, @AUTOR";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            comando.Parameters.AddWithValue("@NOMBRE", nombre);
            comando.Parameters.AddWithValue("@EDITOR", editor);
            comando.Parameters.AddWithValue("@FECHA", fecha);
            comando.Parameters.AddWithValue("@CANTIDAD", cantidad);
            comando.Parameters.AddWithValue("@AUTOR", autor);

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

        public bool AumentarExistencia(SqlConnection conexion, int clave, int cantidad)
        {
            bool aumentado = false;

            try
            {
                conexion.Open();
            }
            catch (SqlException exc)
            {
                Errores = exc;
                conexion.Close();
            }

            string strComando = "EXEC SP_LIBRO_AUMENTAR @CLAVE, @CANTIDAD";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            comando.Parameters.AddWithValue("@CLAVE", clave);
            comando.Parameters.AddWithValue("@CANTIDAD", cantidad);

            try
            {
                comando.ExecuteNonQuery();
                aumentado = true;
            }
            catch (SqlException ex)
            {
                Errores = ex;
                conexion.Close();
            }
            conexion.Close();

            return aumentado;
        }

        public DataTable ObtenerTabla(SqlConnection conexion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("EXEC SP_LIBROS_DATOS", conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Libro = new DataTable();
            da.Fill(Libro);
            conexion.Close();

            return Libro;
        }

        public DataTable ObtenerTablaxAutor(SqlConnection conexion, string autor)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("EXEC SP_LIBROS_BUSQUEDAxAUTOR @AUTOR", conexion);
            comando.Parameters.AddWithValue("@AUTOR", autor);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable busqueda = new DataTable();
            da.Fill(busqueda);
            conexion.Close();

            return busqueda;
        }

        public DataTable ObtenerTablaxEditor(SqlConnection conexion, string editor)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("EXEC SP_LIBROS_BUSQUEDAxEDITOR @EDITOR", conexion);
            comando.Parameters.AddWithValue("@EDITOR", editor);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable busqueda = new DataTable();
            da.Fill(busqueda);
            conexion.Close();

            return busqueda;
        }
    }
}
