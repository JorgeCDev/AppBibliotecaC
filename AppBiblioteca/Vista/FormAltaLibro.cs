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
    public partial class FormAltaLibro : Form
    {
        private SqlConnection conexion;

        public FormAltaLibro(SqlConnection conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
            LlenaEditorial();
            LlenaID();
        }

        private void LlenaEditorial()
        {
            List<string> editorial = new AdmLibros().ObtenerEditorial(conexion);

            for (int i = 0; i < editorial.Count; i++)
                this.cmbEditorial.Items.Add(editorial[i]);
        }

        private void LlenaID()
        {
            txtID.Text = (new AdmLibros().ObtenerID(conexion) + 1).ToString();
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
        private bool ValidaAutor()
        {
            string autor = txtAutor.Text;
            bool validado = true;

            if (string.IsNullOrWhiteSpace(autor) || string.IsNullOrEmpty(autor))
            {
                errorProvider.SetError(txtAutor, "Llenar Autor");
                validado = false;
            }
            return validado;
        }
        private bool ValidaEditor()
        {
            int editor = cmbEditorial.SelectedIndex;
            bool validado = true;

            if (editor < 0)
            {
                errorProvider.SetError(cmbEditorial, "Seleccione una Editorial");
                validado = false;
            }
            return validado;
        }
        private bool ValidaCantidad()
        {
            int cantidad = Convert.ToInt32(numCantidad.Value);
            bool validado = true;
            
            if (cantidad < 1)
            {
                errorProvider.SetError(numCantidad, "Seleccione una Cantidad Valida");
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
            if (!ValidaAutor())
                validado = false;
            if (!ValidaEditor())
                validado = false;
            if (!ValidaCantidad())
                validado = false;

            return validado;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtAutor.Text = "";
            cmbEditorial.SelectedIndex = -1;
            numCantidad.Value = 0;
            dateTimePicker.Value = DateTime.Now;
        }

        private string ObtenerFecha()
        {
            string año = dateTimePicker.Value.Year.ToString();
            string mes = dateTimePicker.Value.Month.ToString();
            string dia = dateTimePicker.Value.Day.ToString();

            return mes + "/" + dia + "/" + año;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                string nombre = txtNombre.Text;
                string autor = txtAutor.Text;
                int editor = cmbEditorial.SelectedIndex + 1;
                int cantidad = Convert.ToInt32(numCantidad.Value);

                bool agregado = new AdmLibros().AgregaLibro(conexion, nombre, editor, ObtenerFecha(), cantidad, autor);

                if (agregado)
                {
                    MessageBox.Show("Libro Agregado con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenaID();
                }
                else
                {
                    MessageBox.Show("ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (SqlError error in AdmLibros.Errores.Errors)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Llena los Elementos Faltantes", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !(numCantidad.Value.ToString().Length < 3) )
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (ValidaNombre())
                errorProvider.Clear();
        }

        private void txtAutor_Validated(object sender, EventArgs e)
        {
            if (ValidaAutor())
                errorProvider.Clear();
        }

        private void cmbEditorial_Validated(object sender, EventArgs e)
        {
            if (ValidaEditor())
                errorProvider.Clear();
        }

        private void numCantidad_Validated(object sender, EventArgs e)
        {
            if (ValidaCantidad())
                errorProvider.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void FormAltaLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
