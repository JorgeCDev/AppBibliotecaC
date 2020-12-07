using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBiblioteca;
using System.Data.SqlClient;
using AppBiblioteca.Vista;

namespace AppBiblioteca
{
    public partial class Menu : Form
    {
        private SqlConnection con;
        private string ConnectionString = "Server=DESKTOP-BSFC1R2; Initial Catalog=Biblioteca; Integrated Security=True";
        public Menu()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionString);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    
        }

        private void menuDosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuTresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void mnMenuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void altasUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaUsuario altaUsuario = new FormAltaUsuario(con);
            altaUsuario.ShowDialog();
        }

        private void altaLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaLibro altaLibro = new FormAltaLibro(con);
            altaLibro.ShowDialog();
        }

        private void aumentarExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAumentarExistencia auEx = new FormAumentarExistencia(con);
            auEx.ShowDialog();
        }

        private void morososToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMorosos frmMor = new FormMorosos(con);
            frmMor.ShowDialog();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaLibro busLib = new FormBusquedaLibro(con);
            busLib.ShowDialog();
        }

        private void reporteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteUsuarios repUs = new FormReporteUsuarios(con);
            repUs.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventario frmInven = new FormInventario(con);
            frmInven.ShowDialog();
        }

        private void prestamoLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamoLibros frmPrest = new FormPrestamoLibros(con);
            frmPrest.ShowDialog();
        }

        private void devolucionLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
