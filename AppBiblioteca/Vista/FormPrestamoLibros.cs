using AppBiblioteca.Modelo;
using AppBiblioteca.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteca.Vista
{
    public partial class FormPrestamoLibros : Form
    {
        private SqlConnection con;
        private Usuario user;
        public FormPrestamoLibros(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;

        }

        public void FillFields(string id)
        {

            if (!id.Equals(""))
            {
                user = new AdmUsuario().GetUsuario(id, con);

                txtNombre.Text = user.NombreCompleto();
                chkMoroso.Checked = user.Mora;
                txtTipoUsuario.Text = user.TipoANombre();
                txtPrestamo.Text = new AdmPrestamos().GetPrestamos(id, con);
            }
        

        }

        private void FormPrestamoLibros_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Keys.Enter==(Keys)e.KeyChar)
            {
                string id = txtID.Text;
                FillFields(id);
            }
            else if (Keys.Back == (Keys)e.KeyChar)
            {

                Limpiar();

            }
         
        }

        public void FillTable()
        {
            dgvLibros.DataSource = new AdmLibros().ObtenerTablaExistencia(con);

        }


        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtTipoUsuario.Text = "";
            chkMoroso.Checked = false;
            txtPrestamo.Text = "";
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {

            if (ValidarVacios())
            {
                MessageBox.Show("No puede haber Campos Vacios");
            }
            else
            {
                Prestamo prestamo = new Prestamo();

                prestamo.Usuario = Convert.ToInt32(txtID.Text);
                prestamo.Libro = Convert.ToInt32(dgvLibros.SelectedCells[0].Value);
                prestamo.Fecha = DateTime.Now;
                int prestados = Convert.ToInt32(txtPrestamo.Text);

                if (ValidaPrestamos(prestados,user.TipoUsuario))
                {
                    MessageBox.Show("Limite de Prestamos Alcanzado");
                    Limpiar();
                }
                else
                {
                    if (chkMoroso.Checked)
                    {
                        MessageBox.Show("Usuario Moroso");
                        Limpiar();
                    }
                    else
                    {
                        new AdmPrestamos().AgregaPrestamo(prestamo, con);
                        new AdmLibros().UpdateExistencia(false, prestamo.Libro.ToString(), con);
                        Limpiar();

                    }

                   
                }
               

            }
           
          
      
        }

        public bool ValidarVacios()
        {

            if (txtID.Text.Equals("")|txtPrestamo.Text.Equals("")|txtTipoUsuario.Equals(""))
                return true;

            return false;

        }

        public bool ValidaPrestamos(int prestamos, int tipoUsuario)
        {

            if (prestamos>=2&tipoUsuario==1|prestamos>=3&tipoUsuario==2|prestamos>=2&tipoUsuario==3)
                return true;

            return false;
        }
    }
}
