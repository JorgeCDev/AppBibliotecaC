namespace AppBiblioteca.Vista
{
    partial class FormReportePrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReportePrestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportePrestamos
            // 
            this.dgvReportePrestamos.AllowUserToAddRows = false;
            this.dgvReportePrestamos.AllowUserToDeleteRows = false;
            this.dgvReportePrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportePrestamos.Location = new System.Drawing.Point(0, 0);
            this.dgvReportePrestamos.Name = "dgvReportePrestamos";
            this.dgvReportePrestamos.ReadOnly = true;
            this.dgvReportePrestamos.Size = new System.Drawing.Size(544, 314);
            this.dgvReportePrestamos.TabIndex = 0;
            // 
            // FormReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 314);
            this.Controls.Add(this.dgvReportePrestamos);
            this.Name = "FormReportePrestamos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Prestamos";
            this.Load += new System.EventHandler(this.FormReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportePrestamos;
    }
}