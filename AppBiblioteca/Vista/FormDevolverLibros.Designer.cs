﻿namespace AppBiblioteca.Vista
{
    partial class FormDevolverLibros
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.chkMoroso = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 27);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.AllowUserToDeleteRows = false;
            this.dgvDevolucion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.Location = new System.Drawing.Point(12, 69);
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(533, 181);
            this.dgvDevolucion.TabIndex = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(417, 266);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(128, 36);
            this.btnDevolver.TabIndex = 2;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // chkMoroso
            // 
            this.chkMoroso.AutoSize = true;
            this.chkMoroso.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMoroso.Location = new System.Drawing.Point(13, 257);
            this.chkMoroso.Name = "chkMoroso";
            this.chkMoroso.Size = new System.Drawing.Size(86, 22);
            this.chkMoroso.TabIndex = 3;
            this.chkMoroso.Text = "Moroso";
            this.chkMoroso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar ID: ";
            // 
            // FormDevolverLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMoroso);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvDevolucion);
            this.Controls.Add(this.txtID);
            this.Name = "FormDevolverLibros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.FormDevolverLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.CheckBox chkMoroso;
        private System.Windows.Forms.Label label1;
    }
}