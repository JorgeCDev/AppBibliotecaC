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
using AppBiblioteca.Persistencia;
namespace AppBiblioteca.Vista
{
    public partial class FormReportePrestamos : Form
    {
        SqlConnection con;
        public FormReportePrestamos(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void FormReportePrestamos_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        public void FillTable()
        {

            dgvReportePrestamos.DataSource = new AdmPrestamos().ReportePrestamos(con);



        }
    }
}
