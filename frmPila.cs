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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        Pila FilaDepersonas = new Pila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtpilaNombre.Text);
            objNodo.Nombre = txtpilaNombre.Text;
            objNodo.Tramite = txtpilaTramite.Text;
            FilaDepersonas.Agregar (objNodo);
            FilaDepersonas.Recorrer(dgvpila);
            txtpilaCodigo.Text = "";
            txtpilaNombre.Text = "";
            txtpilaTramite.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDepersonas.Primero != null)
            {
                txtpilaCodigo2.Text = FilaDepersonas.Primero.Codigo.ToString();
                txtpilatNombre2.Text = FilaDepersonas.Primero.Nombre;
                txtpilaTramite2.Text = FilaDepersonas.Primero.Tramite;
                FilaDepersonas.Eliminar();
                FilaDepersonas.Recorrer(dgvpila);
                FilaDepersonas.Recorrer(ltsPila);
            }
            else
            {
                txtpilaCodigo2.Text = "";
                txtpilatNombre2.Text = "";
                txtpilaTramite2.Text = "";
            }
        }
    }
}
