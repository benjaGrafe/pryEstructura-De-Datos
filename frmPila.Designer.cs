namespace pryEstructura_De_Datos
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltsPila = new System.Windows.Forms.ListBox();
            this.dgvpila = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxeliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtpilaTramite2 = new System.Windows.Forms.TextBox();
            this.txtpilatNombre2 = new System.Windows.Forms.TextBox();
            this.txtpilaCodigo2 = new System.Windows.Forms.TextBox();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtpilaTramite = new System.Windows.Forms.TextBox();
            this.txtpilaNombre = new System.Windows.Forms.TextBox();
            this.txtpilaCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpila)).BeginInit();
            this.gbxeliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(583, 467);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltsPila);
            this.groupBox2.Controls.Add(this.dgvpila);
            this.groupBox2.Location = new System.Drawing.Point(8, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(693, 245);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una lista y una Grilla";
            // 
            // ltsPila
            // 
            this.ltsPila.FormattingEnabled = true;
            this.ltsPila.ItemHeight = 16;
            this.ltsPila.Location = new System.Drawing.Point(-1, 23);
            this.ltsPila.Margin = new System.Windows.Forms.Padding(4);
            this.ltsPila.Name = "ltsPila";
            this.ltsPila.Size = new System.Drawing.Size(212, 212);
            this.ltsPila.TabIndex = 2;
            // 
            // dgvpila
            // 
            this.dgvpila.AllowUserToAddRows = false;
            this.dgvpila.AllowUserToDeleteRows = false;
            this.dgvpila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.Tramite});
            this.dgvpila.Location = new System.Drawing.Point(220, 32);
            this.dgvpila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpila.Name = "dgvpila";
            this.dgvpila.ReadOnly = true;
            this.dgvpila.RowHeadersWidth = 51;
            this.dgvpila.Size = new System.Drawing.Size(473, 206);
            this.dgvpila.TabIndex = 1;
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
            this.gbxeliminar.Controls.Add(this.txtpilaTramite2);
            this.gbxeliminar.Controls.Add(this.txtpilatNombre2);
            this.gbxeliminar.Controls.Add(this.txtpilaCodigo2);
            this.gbxeliminar.Controls.Add(this.lblTramite2);
            this.gbxeliminar.Controls.Add(this.lblNombre2);
            this.gbxeliminar.Controls.Add(this.lblCodigo2);
            this.gbxeliminar.Location = new System.Drawing.Point(485, 3);
            this.gbxeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gbxeliminar.Name = "gbxeliminar";
            this.gbxeliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gbxeliminar.Size = new System.Drawing.Size(216, 217);
            this.gbxeliminar.TabIndex = 15;
            this.gbxeliminar.TabStop = false;
            this.gbxeliminar.Text = " Elemento  Eliminsdo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(64, 181);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtpilaTramite2
            // 
            this.txtpilaTramite2.Location = new System.Drawing.Point(64, 145);
            this.txtpilaTramite2.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilaTramite2.Name = "txtpilaTramite2";
            this.txtpilaTramite2.Size = new System.Drawing.Size(132, 22);
            this.txtpilaTramite2.TabIndex = 5;
            // 
            // txtpilatNombre2
            // 
            this.txtpilatNombre2.Location = new System.Drawing.Point(64, 82);
            this.txtpilatNombre2.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilatNombre2.Name = "txtpilatNombre2";
            this.txtpilatNombre2.Size = new System.Drawing.Size(132, 22);
            this.txtpilatNombre2.TabIndex = 4;
            // 
            // txtpilaCodigo2
            // 
            this.txtpilaCodigo2.Location = new System.Drawing.Point(64, 36);
            this.txtpilaCodigo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilaCodigo2.Name = "txtpilaCodigo2";
            this.txtpilaCodigo2.Size = new System.Drawing.Size(132, 22);
            this.txtpilaCodigo2.TabIndex = 3;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(9, 149);
            this.lblTramite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(53, 16);
            this.lblTramite2.TabIndex = 2;
            this.lblTramite2.Text = "Tramite";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(9, 91);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(56, 16);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(9, 39);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gbxNuevoElemento
            // 
            this.gbxNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbxNuevoElemento.Controls.Add(this.txtpilaTramite);
            this.gbxNuevoElemento.Controls.Add(this.txtpilaNombre);
            this.gbxNuevoElemento.Controls.Add(this.txtpilaCodigo);
            this.gbxNuevoElemento.Controls.Add(this.lblTramite);
            this.gbxNuevoElemento.Controls.Add(this.lblNombre);
            this.gbxNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbxNuevoElemento.Location = new System.Drawing.Point(228, 3);
            this.gbxNuevoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gbxNuevoElemento.Name = "gbxNuevoElemento";
            this.gbxNuevoElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gbxNuevoElemento.Size = new System.Drawing.Size(216, 217);
            this.gbxNuevoElemento.TabIndex = 13;
            this.gbxNuevoElemento.TabStop = false;
            this.gbxNuevoElemento.Text = "Nuevo Elemento ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 181);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtpilaTramite
            // 
            this.txtpilaTramite.Location = new System.Drawing.Point(64, 145);
            this.txtpilaTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilaTramite.Name = "txtpilaTramite";
            this.txtpilaTramite.Size = new System.Drawing.Size(132, 22);
            this.txtpilaTramite.TabIndex = 5;
            // 
            // txtpilaNombre
            // 
            this.txtpilaNombre.Location = new System.Drawing.Point(64, 82);
            this.txtpilaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilaNombre.Name = "txtpilaNombre";
            this.txtpilaNombre.Size = new System.Drawing.Size(132, 22);
            this.txtpilaNombre.TabIndex = 4;
            // 
            // txtpilaCodigo
            // 
            this.txtpilaCodigo.Location = new System.Drawing.Point(64, 36);
            this.txtpilaCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtpilaCodigo.Name = "txtpilaCodigo";
            this.txtpilaCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtpilaCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(9, 149);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(53, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 91);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 499);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxeliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxNuevoElemento);
            this.Name = "frmPila";
            this.Text = "frmPila";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpila)).EndInit();
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
        private System.Windows.Forms.ListBox ltsPila;
        private System.Windows.Forms.DataGridView dgvpila;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbxeliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtpilaTramite2;
        private System.Windows.Forms.TextBox txtpilatNombre2;
        private System.Windows.Forms.TextBox txtpilaCodigo2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtpilaTramite;
        private System.Windows.Forms.TextBox txtpilaNombre;
        private System.Windows.Forms.TextBox txtpilaCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}