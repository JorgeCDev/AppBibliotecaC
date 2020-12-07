using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppBiblioteca.Modelo;

namespace AppBiblioteca.Persistencia
{
    public class AdmPrestamos
    {
       
        public AdmPrestamos()
        {


        }


        public string GetPrestamos(string id, SqlConnection con)
        {

            con.Open();
            
            string query = "SELECT COUNT(*) FROM Prestamo WHERE UsuarioID = "+id;

            SqlCommand comando = new SqlCommand(query, con);

            string ID = comando.ExecuteScalar().ToString();
            con.Close();

            return ID.ToString() ;

        }

        public void AgregaPrestamo(Prestamo pres,SqlConnection con)
        {
            string query = "INSERT INTO[dbo].[Prestamo] ([LibroID],[UsuarioID],[FechaPrestamo]) VALUES (@libroID,@UsuarioID,@fecha)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@libroID", pres.Libro);
            cmd.Parameters.AddWithValue("@UsuarioID", pres.Usuario);
            cmd.Parameters.AddWithValue("@fecha", pres.Fecha);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


        }



        
    }
}
