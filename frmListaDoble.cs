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
                    objOrdenListaD.Agregar(objNodo);
                    objOrdenListaD.Recorrer(dgvLD);
                    objOrdenListaD.Recorrer(ltsLD);
                    objOrdenListaD.Recorrer(cmbCodigoLD);

                    txtCodigoLD.Text = "";
                    txtNombreLD.Text = "";
                    txtTramiteLD.Text = "";
                }
                else
                {
                    objOrdenListaD.Agregar(objNodo);
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
    }
}
