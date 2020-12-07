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
    public partial class FormInventario : Form
    {
        public FormInventario(SqlConnection conexion)
        {            
            InitializeComponent();
            LlenaTabla(conexion);
        }

        private void LlenaTabla(SqlConnection conexion)
        {
            dataGridView.DataSource = new AdmLibros().ObtenerTabla(conexion);
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
