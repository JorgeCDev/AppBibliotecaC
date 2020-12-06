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

namespace Biblioteca.Libros
{
    public partial class FormBusquedaLibro : Form
    {
        SqlConnection conexion;

        public FormBusquedaLibro(SqlConnection conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
            rbAutor.Checked = true;
        }

        private void Buscar()
        {
            string busqueda = txtBusqueda.Text;

            if (rbAutor.Checked)
            {
                dataGridView.DataSource = new AdmLibros().ObtenerTablaxAutor(conexion, busqueda);
            }
            else
            {
                dataGridView.DataSource = new AdmLibros().ObtenerTablaxEditor(conexion, busqueda);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Buscar();
        }
    }
}
