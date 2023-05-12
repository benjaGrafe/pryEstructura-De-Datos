namespace pryEstructura_De_Datos
{
    partial class frmArbolBinario
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltsLista = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxeliminar = new System.Windows.Forms.GroupBox();
            this.cmbEstructurasRamificadas = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbxNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnInOden = new System.Windows.Forms.RadioButton();
            this.btnPreOrden = new System.Windows.Forms.RadioButton();
            this.btnPosOrden = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TVarbolbinario = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gbxeliminar.SuspendLayout();
            this.gbxNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(651, 580);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 35);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltsLista);
            this.groupBox2.Controls.Add(this.dgvGrilla);
            this.groupBox2.Location = new System.Drawing.Point(10, 299);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(811, 291);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una lista y una Grilla";
            // 
            // ltsLista
            // 
            this.ltsLista.FormattingEnabled = true;
            this.ltsLista.ItemHeight = 20;
            this.ltsLista.Location = new System.Drawing.Point(8, 29);
            this.ltsLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltsLista.Name = "ltsLista";
            this.ltsLista.Size = new System.Drawing.Size(252, 244);
            this.ltsLista.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.Tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(268, 40);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(532, 231);
            this.dgvGrilla.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
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
            this.gbxeliminar.Controls.Add(this.cmbEstructurasRamificadas);
            this.gbxeliminar.Controls.Add(this.btnEliminar);
            this.gbxeliminar.Controls.Add(this.lblCodigo2);
            this.gbxeliminar.Location = new System.Drawing.Point(567, 19);
            this.gbxeliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxeliminar.Name = "gbxeliminar";
            this.gbxeliminar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxeliminar.Size = new System.Drawing.Size(243, 161);
            this.gbxeliminar.TabIndex = 20;
            this.gbxeliminar.TabStop = false;
            this.gbxeliminar.Text = " Elemento  Eliminar";
            // 
            // cmbEstructurasRamificadas
            // 
            this.cmbEstructurasRamificadas.FormattingEnabled = true;
            this.cmbEstructurasRamificadas.Location = new System.Drawing.Point(84, 49);
            this.cmbEstructurasRamificadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstructurasRamificadas.Name = "cmbEstructurasRamificadas";
            this.cmbEstructurasRamificadas.Size = new System.Drawing.Size(148, 28);
            this.cmbEstructurasRamificadas.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(13, 94);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(9, 49);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Codigo";
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
            this.gbxNuevoElemento.Location = new System.Drawing.Point(278, 19);
            this.gbxNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxNuevoElemento.Name = "gbxNuevoElemento";
            this.gbxNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxNuevoElemento.Size = new System.Drawing.Size(243, 271);
            this.gbxNuevoElemento.TabIndex = 18;
            this.gbxNuevoElemento.TabStop = false;
            this.gbxNuevoElemento.Text = "Nuevo Elemento ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(86, 226);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(72, 172);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(148, 26);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 45);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(10, 178);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(62, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 114);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 49);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnInOden
            // 
            this.btnInOden.AutoSize = true;
            this.btnInOden.Location = new System.Drawing.Point(15, 27);
            this.btnInOden.Name = "btnInOden";
            this.btnInOden.Size = new System.Drawing.Size(92, 24);
            this.btnInOden.TabIndex = 23;
            this.btnInOden.TabStop = true;
            this.btnInOden.Text = "InOrden";
            this.btnInOden.UseVisualStyleBackColor = true;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.AutoSize = true;
            this.btnPreOrden.Location = new System.Drawing.Point(15, 60);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(102, 24);
            this.btnPreOrden.TabIndex = 24;
            this.btnPreOrden.TabStop = true;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            // 
            // btnPosOrden
            // 
            this.btnPosOrden.AutoSize = true;
            this.btnPosOrden.Location = new System.Drawing.Point(15, 90);
            this.btnPosOrden.Name = "btnPosOrden";
            this.btnPosOrden.Size = new System.Drawing.Size(105, 24);
            this.btnPosOrden.TabIndex = 25;
            this.btnPosOrden.TabStop = true;
            this.btnPosOrden.Text = "PosOrden";
            this.btnPosOrden.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPosOrden);
            this.groupBox1.Controls.Add(this.btnInOden);
            this.groupBox1.Controls.Add(this.btnPreOrden);
            this.groupBox1.Location = new System.Drawing.Point(542, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(128, 124);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Orden ";
            // 
            // TVarbolbinario
            // 
            this.TVarbolbinario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVarbolbinario.Location = new System.Drawing.Point(10, 19);
            this.TVarbolbinario.Margin = new System.Windows.Forms.Padding(2);
            this.TVarbolbinario.Name = "TVarbolbinario";
            this.TVarbolbinario.Size = new System.Drawing.Size(260, 271);
            this.TVarbolbinario.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDescendente);
            this.groupBox3.Controls.Add(this.btnAscendente);
            this.groupBox3.Location = new System.Drawing.Point(669, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(144, 124);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Orden ";
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Location = new System.Drawing.Point(11, 90);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(130, 24);
            this.btnDescendente.TabIndex = 25;
            this.btnDescendente.TabStop = true;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Location = new System.Drawing.Point(15, 27);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(118, 24);
            this.btnAscendente.TabIndex = 23;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TVarbolbinario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxeliminar);
            this.Controls.Add(this.gbxNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gbxeliminar.ResumeLayout(false);
            this.gbxeliminar.PerformLayout();
            this.gbxNuevoElemento.ResumeLayout(false);
            this.gbxNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ltsLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbxeliminar;
        private System.Windows.Forms.ComboBox cmbEstructurasRamificadas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbxNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton btnInOden;
        private System.Windows.Forms.RadioButton btnPreOrden;
        private System.Windows.Forms.RadioButton btnPosOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TVarbolbinario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
    }
}