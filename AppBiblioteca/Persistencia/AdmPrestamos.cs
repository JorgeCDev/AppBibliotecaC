using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppBiblioteca.Modelo;
using System.Data;

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

        public DataTable PrestamosUsuario(string id,SqlConnection con)
        {
            string query = "SELECT Prestamo.PrestamoID as ID, Usuario.Nombre+' '+Usuario.ApePaterno+' '+Usuario.ApeMaterno as Nombre, Libro.Libro, Prestamo.FechaPrestamo as Fecha,DATEDIFF(dd,Prestamo.FechaPrestamo,GETDATE()) AS Transcurridos FROM Prestamo " +
                "inner join Usuario on Usuario.UsuarioID = Prestamo.UsuarioID "+
                "inner join Libro on Libro.LibroID = Prestamo.LibroID " +
                "WHERE Prestamo.UsuarioID = " + id;
            
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Libro = new DataTable();
            da.Fill(Libro);
            con.Close();

            return Libro;


        }



        
    }
}
