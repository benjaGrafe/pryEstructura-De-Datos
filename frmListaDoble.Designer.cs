namespace pryEstructura_De_Datos
{
    partial class frmListaDoble
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltsLD = new System.Windows.Forms.ListBox();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteLD = new System.Windows.Forms.TextBox();
            this.txtNombreLD = new System.Windows.Forms.TextBox();
            this.txtCodigoLD = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodigoLD = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDescendenteLD = new System.Windows.Forms.RadioButton();
            this.rdbAscendenteLD = new System.Windows.Forms.RadioButton();
            this.grvcodigoLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltsLD);
            this.groupBox2.Controls.Add(this.dgvLD);
            this.groupBox2.Location = new System.Drawing.Point(13, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 199);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una lista y una Grilla";
            // 
            // ltsLD
            // 
            this.ltsLD.FormattingEnabled = true;
            this.ltsLD.Location = new System.Drawing.Point(6, 19);
            this.ltsLD.Name = "ltsLD";
            this.ltsLD.Size = new System.Drawing.Size(141, 160);
            this.ltsLD.TabIndex = 2;
            // 
            // dgvLD
            // 
            this.dgvLD.AllowUserToAddRows = false;
            this.dgvLD.AllowUserToDeleteRows = false;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvcodigoLD,
            this.ombre,
            this.Tramite});
            this.dgvLD.Location = new System.Drawing.Point(165, 29);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.ReadOnly = true;
            this.dgvLD.RowHeadersWidth = 51;
            this.dgvLD.Size = new System.Drawing.Size(337, 150);
            this.dgvLD.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gbxNuevoElemento
            // 
            this.gbxNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbxNuevoElemento.Controls.Add(this.txtTramiteLD);
            this.gbxNuevoElemento.Controls.Add(this.txtNombreLD);
            this.gbxNuevoElemento.Controls.Add(this.txtCodigoLD);
            this.gbxNuevoElemento.Controls.Add(this.lblTramite);
            this.gbxNuevoElemento.Controls.Add(this.lblNombre);
            this.gbxNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbxNuevoElemento.Location = new System.Drawing.Point(178, 21);
            this.gbxNuevoElemento.Name = "gbxNuevoElemento";
            this.gbxNuevoElemento.Size = new System.Drawing.Size(162, 176);
            this.gbxNuevoElemento.TabIndex = 13;
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
            // txtTramiteLD
            // 
            this.txtTramiteLD.Location = new System.Drawing.Point(48, 118);
            this.txtTramiteLD.Name = "txtTramiteLD";
            this.txtTramiteLD.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteLD.TabIndex = 5;
            // 
            // txtNombreLD
            // 
            this.txtNombreLD.Location = new System.Drawing.Point(48, 67);
            this.txtNombreLD.Name = "txtNombreLD";
            this.txtNombreLD.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLD.TabIndex = 4;
            // 
            // txtCodigoLD
            // 
            this.txtCodigoLD.Location = new System.Drawing.Point(48, 29);
            this.txtCodigoLD.Name = "txtCodigoLD";
            this.txtCodigoLD.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLD.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCodigoLD);
            this.groupBox1.Location = new System.Drawing.Point(349, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 122);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(19, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 47);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // cmbCodigoLD
            // 
            this.cmbCodigoLD.FormattingEnabled = true;
            this.cmbCodigoLD.Location = new System.Drawing.Point(86, 32);
            this.cmbCodigoLD.Name = "cmbCodigoLD";
            this.cmbCodigoLD.Size = new System.Drawing.Size(79, 21);
            this.cmbCodigoLD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDescendenteLD);
            this.groupBox3.Controls.Add(this.rdbAscendenteLD);
            this.groupBox3.Location = new System.Drawing.Point(347, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 69);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbDescendenteLD
            // 
            this.rdbDescendenteLD.AutoSize = true;
            this.rdbDescendenteLD.Location = new System.Drawing.Point(6, 41);
            this.rdbDescendenteLD.Name = "rdbDescendenteLD";
            this.rdbDescendenteLD.Size = new System.Drawing.Size(89, 17);
            this.rdbDescendenteLD.TabIndex = 1;
            this.rdbDescendenteLD.TabStop = true;
            this.rdbDescendenteLD.Text = "Descendente";
            this.rdbDescendenteLD.UseVisualStyleBackColor = true;
            // 
            // rdbAscendenteLD
            // 
            this.rdbAscendenteLD.AutoSize = true;
            this.rdbAscendenteLD.Location = new System.Drawing.Point(6, 18);
            this.rdbAscendenteLD.Name = "rdbAscendenteLD";
            this.rdbAscendenteLD.Size = new System.Drawing.Size(82, 17);
            this.rdbAscendenteLD.TabIndex = 0;
            this.rdbAscendenteLD.TabStop = true;
            this.rdbAscendenteLD.Text = "Ascendente";
            this.rdbAscendenteLD.UseVisualStyleBackColor = true;
            // 
            // grvcodigoLD
            // 
            this.grvcodigoLD.HeaderText = "codigo";
            this.grvcodigoLD.MinimumWidth = 6;
            this.grvcodigoLD.Name = "grvcodigoLD";
            this.grvcodigoLD.ReadOnly = true;
            this.grvcodigoLD.Width = 125;
            // 
            // ombre
            // 
            this.ombre.HeaderText = "nombre";
            this.ombre.MinimumWidth = 6;
            this.ombre.Name = "ombre";
            this.ombre.ReadOnly = true;
            this.ombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            this.Tramite.Width = 125;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxNuevoElemento);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxNuevoElemento.ResumeLayout(false);
            this.gbxNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ltsLD;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteLD;
        private System.Windows.Forms.TextBox txtNombreLD;
        private System.Windows.Forms.TextBox txtCodigoLD;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodigoLD;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDescendenteLD;
        private System.Windows.Forms.RadioButton rdbAscendenteLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvcodigoLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}