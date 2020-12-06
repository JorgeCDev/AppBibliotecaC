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
using AppBiblioteca.Persistencia;

namespace AppBiblioteca.Vista
{
    public partial class FormReporteUsuarios : Form
    {
        public FormReporteUsuarios(SqlConnection conexion)
        {
            InitializeComponent();
            LlenaTabla(conexion);
        }

        private void LlenaTabla(SqlConnection conexion)
        {
            dataGridView.DataSource = new AdmUsuario().ObtenerTabla(conexion);
        }

        private void FormReporteUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
