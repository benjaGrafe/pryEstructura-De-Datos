﻿namespace pryEstructura_De_Datos
{
    partial class frmCola
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltsCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxeliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramite2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.gbxeliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(441, 388);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltsCola);
            this.groupBox2.Controls.Add(this.dgvCola);
            this.groupBox2.Location = new System.Drawing.Point(10, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 199);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una lista y una Grilla";
            // 
            // ltsCola
            // 
            this.ltsCola.FormattingEnabled = true;
            this.ltsCola.Location = new System.Drawing.Point(-1, 19);
            this.ltsCola.Name = "ltsCola";
            this.ltsCola.Size = new System.Drawing.Size(160, 160);
            this.ltsCola.TabIndex = 2;
            // 
            // dgvCola
            // 
            this.dgvCola.AllowUserToAddRows = false;
            this.dgvCola.AllowUserToDeleteRows = false;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.Tramite});
            this.dgvCola.Location = new System.Drawing.Point(165, 26);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.ReadOnly = true;
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(355, 150);
            this.dgvCola.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "cidigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            this.Tramite.Width = 125;
            // 
            // gbxeliminar
            // 
            this.gbxeliminar.Controls.Add(this.btnEliminar);
            this.gbxeliminar.Controls.Add(this.txtTramite2);
            this.gbxeliminar.Controls.Add(this.txtNombre2);
            this.gbxeliminar.Controls.Add(this.txtCodigo2);
            this.gbxeliminar.Controls.Add(this.lblTramite2);
            this.gbxeliminar.Controls.Add(this.lblNombre2);
            this.gbxeliminar.Controls.Add(this.lblCodigo2);
            this.gbxeliminar.Location = new System.Drawing.Point(368, 11);
            this.gbxeliminar.Name = "gbxeliminar";
            this.gbxeliminar.Size = new System.Drawing.Size(162, 176);
            this.gbxeliminar.TabIndex = 10;
            this.gbxeliminar.TabStop = false;
            this.gbxeliminar.Text = " Elemento  Eliminsdo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(48, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTramite2
            // 
            this.txtTramite2.Location = new System.Drawing.Point(48, 118);
            this.txtTramite2.Name = "txtTramite2";
            this.txtTramite2.Size = new System.Drawing.Size(100, 20);
            this.txtTramite2.TabIndex = 5;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(48, 67);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 4;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(48, 29);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 3;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(7, 121);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(42, 13);
            this.lblTramite2.TabIndex = 2;
            this.lblTramite2.Text = "Tramite";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(7, 74);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(7, 32);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // gbxNuevoElemento
            // 
            this.gbxNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbxNuevoElemento.Controls.Add(this.txtTramite);
            this.gbxNuevoElemento.Controls.Add(this.txtNombre);
            this.gbxNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbxNuevoElemento.Controls.Add(this.lblTramite);
            this.gbxNuevoElemento.Controls.Add(this.lblNombre);
            this.gbxNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbxNuevoElemento.Location = new System.Drawing.Point(175, 11);
            this.gbxNuevoElemento.Name = "gbxNuevoElemento";
            this.gbxNuevoElemento.Size = new System.Drawing.Size(162, 176);
            this.gbxNuevoElemento.TabIndex = 8;
            this.gbxNuevoElemento.TabStop = false;
            this.gbxNuevoElemento.Text = "Nuevo Elemento ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(48, 118);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(48, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(7, 121);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(556, 418);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxeliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCola";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.gbxeliminar.ResumeLayout(false);
            this.gbxeliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxNuevoElemento.ResumeLayout(false);
            this.gbxNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ltsCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbxeliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramite2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}

