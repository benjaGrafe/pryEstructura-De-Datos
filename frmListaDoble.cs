using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objOrdenListaD = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo objNodo = new Nodo();
                objNodo.Codigo = Convert.ToInt32(txtCodigoLD.Text);
                objNodo.Nombre = txtNombreLD.Text;
                objNodo.Tramite = txtTramiteLD.Text;

                if (rdbAscendenteLD.Enabled == true)
                {
                    objOrdenListaD.agregar(objNodo);
                    objOrdenListaD.RecorrerAs(dgvLD);
                    objOrdenListaD.RecorrerAs(ltsLD);
                    objOrdenListaD.RecorrerAs(cmbCodigoLD);

                    txtCodigoLD.Text = "";
                    txtNombreLD.Text = "";
                    txtTramiteLD.Text = "";
                }
                else
                {
                    objOrdenListaD.agregar(objNodo);
                    objOrdenListaD.RecorrerDes(dgvLD);
                    objOrdenListaD.RecorrerDes(ltsLD);
                    objOrdenListaD.RecorrerDes(cmbCodigoLD);

                    txtCodigoLD.Text = "";
                    txtNombreLD.Text = "";
                    txtTramiteLD.Text = "";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("tranqui, de a poquito se hace");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ( objOrdenListaD.primero != null )
            {
                Int32 Eliminar = Convert.ToInt32(cmbCodigoLD.Text);
                objOrdenListaD.Eliminar(Eliminar);
                objOrdenListaD.RecorrerAs(dgvLD);
                objOrdenListaD.RecorrerAs(ltsLD);
                objOrdenListaD.RecorrerAs(cmbCodigoLD);
            }
        }
    }
}
