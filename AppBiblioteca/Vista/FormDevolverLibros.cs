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
            if (char.IsLetter(e.KeyChar) & (Keys)char.ToUpper(e.KeyChar) != Keys.Back & (Keys)char.ToUpper(e.KeyChar) != Keys.Space)
            {
                e.Handled = true;
            }
       
            if (Keys.Enter==(Keys)e.KeyChar&!txtID.Text.Equals(""))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    FillTable(txtID.Text);
                }
                
            }
        }


        public void limpiar()
        {

            txtID.Text = "";
            chkMoroso.Checked = false;
            dgvDevolucion.DataSource=null;
            
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {

            

            if (chkMoroso.Checked)
            {
                new AdmUsuario().UpdateMoroso(true,txtID.Text,con);
                string prestamo = dgvDevolucion.SelectedCells[0].Value.ToString();
                new AdmPrestamos().QuitaPrestamo(prestamo,con);
                limpiar();

            }
            else
            {
                string prestamo = dgvDevolucion.SelectedCells[0].Value.ToString();
                new AdmPrestamos().QuitaPrestamo(prestamo, con);
                limpiar();
            }
            }
        }
    }
}
