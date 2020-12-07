using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppBiblioteca.Persistencia;

namespace AppBiblioteca.Vista
{
    public partial class FormMorosos : Form
    {
        private SqlConnection con;
        public FormMorosos(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void FormMorosos_Load(object sender, EventArgs e)
        {

            FillTable();

            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvMorosos.SelectedRows.Count > 0)
            {
                string usuario = dgvMorosos.SelectedCells[0].Value.ToString();
                new AdmUsuario().UpdateMoroso(usuario, con);
                FillTable();
            }
       
        }

        public void FillTable()
        {

            dgvMorosos.DataSource = new AdmUsuario().ObtenerTablaMorosos(con);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
