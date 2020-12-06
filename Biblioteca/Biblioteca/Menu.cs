using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Menu : Form
    {
        private SqlConnection conexion;

        public Menu()
        {
            InitializeComponent();

            string strConexion = "Data Source=IVANVS-GAMER;Initial Catalog=Biblioteca;Integrated Security=True";
            this.conexion = new SqlConnection(strConexion);

            ProbarConexion(conexion);
        }

        public void ProbarConexion(SqlConnection conexion)
        {   
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR AL CONECTAR", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show(error.Message);
                }
                conexion.Close();
            }
            conexion.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuario.FormAltaUsuario(conexion).ShowDialog();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuario.FormReporteUsuarios(conexion).ShowDialog();
        }

        private void altasDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Libros.FormAltaLibro(conexion).ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Libros.FormInventario(conexion).ShowDialog();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Libros.FormBusquedaLibro(conexion).ShowDialog();
        }

        private void aumentarExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Libros.FormAumentarExistencia(conexion).ShowDialog();
        }
    }
}
