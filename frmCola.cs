using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        Cola filaDepersonas = new Cola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            filaDepersonas.Agregar(objNodo);
            filaDepersonas.Recorrer(dgvCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaDepersonas.primero != null)
            {
                txtCodigo2.Text = filaDepersonas.primero.Codigo.ToString();
                txtNombre2.Text = filaDepersonas.primero.Nombre;
                txtTramite2.Text = filaDepersonas.primero.Tramite;
                filaDepersonas.Eliminar();
                filaDepersonas.Recorrer(dgvCola);
                filaDepersonas.Recorrer(ltsCola);
            }
            else
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                txtTramite2.Text = "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
