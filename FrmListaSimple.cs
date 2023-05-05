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
    public partial class FrmListaSimple : Form
    {
        public FrmListaSimple()
        {
            InitializeComponent();
        }
        clslistasimple list = new clslistasimple();         
        private void lblCodigo2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (list.primero != null)
            {
                Int32 X = Convert.ToInt32(cmbCodigoLS.Text);
                list.ELIMINAR(X);
                list.Recorrer(dgvListaSimple);
                list.Recorrer(ltsListaSimple);
                list.Recorrer(cmbCodigoLS);


            }
            else
            {
                MessageBox.Show("esta vacio");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = Convert.ToInt32(cmbCodigoLS.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            list.agregar(nodo);
            list.Recorrer(cmbCodigoLS);
            list.Recorrer(ltsListaSimple);
            list.Recorrer(dgvListaSimple);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
