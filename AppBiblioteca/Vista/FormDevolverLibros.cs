using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBiblioteca.Persistencia;
using System.Data.SqlClient;

namespace AppBiblioteca.Vista
{
    public partial class FormDevolverLibros : Form
    {

        private SqlConnection con;
        public FormDevolverLibros(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void FormDevolverLibros_Load(object sender, EventArgs e)
        {

        }

        public void FillTable(string id)
        {            
            dgvDevolucion.DataSource = new AdmPrestamos().PrestamosUsuario(id,con);

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Keys.Enter==(Keys)e.KeyChar)
            {
                if (!string.IsNullOrEmpty(txtID.Text)|!char.IsDigit(e.KeyChar))
                {
                    FillTable(txtID.Text);
                }
                
            }
        }
    }
}
