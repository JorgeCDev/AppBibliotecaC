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
    public partial class FormAltaUsuario : Form
    {
        private SqlConnection conexion;

        public FormAltaUsuario(SqlConnection conexion)
        {
            this.conexion = conexion;
            InitializeComponent();

            LlenaTipo();
            LlenaCiudad();
        }

        private void LlenaTipo()
        {
            List<string> tipo = new AdmUsuario().ObtenerTipo(conexion);

            for (int i = 0; i < tipo.Count; i++)
                this.cmbTipoUsuario.Items.Add(tipo[i]);            
        }

        private void LlenaCiudad()
        {
            List<string> ciudad = new AdmUsuario().ObtenerCiudad(conexion);

            for (int i = 0; i < ciudad.Count; i++)
                this.cmbCiudad.Items.Add(ciudad[i]);
        }

        private bool ValidaNombre()
        {
            string nombre = txtNombre.Text;
            bool validado = true;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider.SetError(txtNombre, "Llenar Nombre");
                validado = false;
            }
            return validado;
        }
        private bool ValidaApePat()
        {
            string apePat = txtApePaterno.Text;
            bool validado = true;

            if (string.IsNullOrWhiteSpace(apePat) || string.IsNullOrEmpty(apePat))
            {
                errorProvider.SetError(txtApePaterno, "Llenar Apellido Paterno");
                validado = false;
            }
            return validado;
        }
        private bool ValidaApeMat()
        {
            string apeMat = txtApeMaterno.Text;
            bool validado = true;

            if (string.IsNullOrWhiteSpace(apeMat) || string.IsNullOrEmpty(apeMat))
            {
                errorProvider.SetError(txtApeMaterno, "Llenar Apellido Materno");
                validado = false;
            }
            return validado;
        }
        private bool ValidaCiudad()
        {
            int ciudad = cmbCiudad.SelectedIndex;
            bool validado = true;

            if (ciudad < 0)
            {
                errorProvider.SetError(cmbCiudad, "Seleccione una Ciudad");
                validado = false;
            }
            return validado;
        }
        private bool ValidaTipo()
        {
            int tipo = cmbTipoUsuario.SelectedIndex;
            bool validado = true;
            if (tipo < 0)
            {
                errorProvider.SetError(cmbTipoUsuario, "Seleccione Tipo de Usuario");
                validado = false;
            }
            return validado;
        }

        private bool ValidaDatos()
        {
            bool validado = true;

            errorProvider.Clear();
            if (!ValidaNombre())
                validado = false;
            if (!ValidaApePat())
                validado = false;
            if (!ValidaApeMat())
                validado = false;
            if (!ValidaCiudad())
                validado = false;
            if (!ValidaTipo())
                validado = false;
            return validado;
        }

        private void Limpiar()
        {
            txtNombre.Text = "" ;
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtDescripcion.Text = "";
            cmbCiudad.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {    
            if(ValidaDatos())
            {
                string nombre = txtNombre.Text;
                string apePat = txtApePaterno.Text;
                string apeMat = txtApeMaterno.Text;
                int ciudad = cmbCiudad.SelectedIndex + 1;
                int tipo = cmbTipoUsuario.SelectedIndex + 1;

                bool agregado = new AdmUsuario().AgregaUsuario(conexion, nombre, apePat, apeMat, ciudad, tipo);

                if (agregado)
                {
                    MessageBox.Show("Usuario Agregado con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (SqlError error in AdmUsuario.Errores.Errors)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Llena los Elementos Faltantes","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (ValidaNombre())
                errorProvider.Clear();            
        }

        private void txtApePaterno_Validated(object sender, EventArgs e)
        {
            if (ValidaApePat())
                errorProvider.Clear();
        }

        private void txtApeMaterno_Validated(object sender, EventArgs e)
        {
            if (ValidaApeMat())
                errorProvider.Clear();
        }

        private void cmbCiudad_Validated(object sender, EventArgs e)
        {
            if (ValidaCiudad())
                errorProvider.Clear();
        }

        private void cmbTipoUsuario_Validated(object sender, EventArgs e)
        {
            if (ValidaTipo())
                errorProvider.Clear();
        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
