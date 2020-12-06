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
    public partial class FormAumentarExistencia : Form
    {
        SqlConnection conexion;

        public FormAumentarExistencia(SqlConnection conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
            LlenaIDs();
            LlenaNombres();
        }

        private void LlenaIDs()
        {
            List<string> IDs = new AdmLibros().TodosID(conexion);

            for (int i = 0; i < IDs.Count; i++)
                this.cmbID.Items.Add(IDs[i]);
        }

        private void LlenaNombres()
        {
            List<string> Nombres = new AdmLibros().TodosNombres(conexion);

            for (int i = 0; i < Nombres.Count; i++)
                this.cmbNombre.Items.Add(Nombres[i]);
        }

        private bool ValidaID()
        {
            bool validado = true;
            int ID = cmbID.SelectedIndex;
            if (ID < 0)
            {
                errorProvider.SetError(cmbID, "Seleccione un ID");
                validado = false;
            }
            return validado;
        }
        private bool ValidaLibro()
        {
            bool validado = true;
            int nombre = cmbNombre.SelectedIndex;
            if (nombre < 0)
            {
                errorProvider.SetError(cmbNombre, "Seleccione un Libro");
                validado = false;
            }
            return validado;
        }
        private bool ValidaCantidad()
        {
            bool validado = true;
            int cantidad = Convert.ToInt32(numCantidad.Value);

            if (cantidad < 1)
            {
                errorProvider.SetError(numCantidad, "Cantidad Incorrecta");
                validado = false;
            }
            return validado;
        }
        private bool ValidarDatos()
        {
            bool validado = true;
            errorProvider.Clear();
            if (!ValidaID())
                validado = false;
            if (!ValidaLibro())
                validado = false;
            if (!ValidaCantidad())
                validado = false;
            return validado;
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbID.SelectedItem.ToString();
            cmbNombre.SelectedItem = new AdmLibros().ObtenerElNombre(conexion,clave);
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cmbNombre.SelectedItem.ToString();
            cmbID.SelectedItem = new AdmLibros().ObtenerElID(conexion, nombre);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                int clave = Convert.ToInt32(cmbID.SelectedItem.ToString());
                int cantidad = Convert.ToInt32(numCantidad.Value);

                bool aumentado = new AdmLibros().AumentarExistencia(conexion,clave,cantidad);

                if(aumentado)
                {
                    MessageBox.Show("Inventario Actualizado con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!(numCantidad.Value.ToString().Length < 3))
            {
                e.Handled = true;
            }
        }

        private void cmbID_Validated(object sender, EventArgs e)
        {            
            if ( ValidaID() )
                errorProvider.Clear();
        }

        private void cmbNombre_Validated(object sender, EventArgs e)
        {
            if (ValidaLibro())
                errorProvider.Clear();
        }
    }
}
