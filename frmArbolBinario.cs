using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    public partial class frmArbolBinario : Form
    {

        clsArbolBinario Arbol = new clsArbolBinario();

        public bool asc =true;
        public string recorrer;


        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((Arbol.Raiz != null) && (cmbEstructurasRamificadas.SelectedIndex != -1))
            {
                Arbol.Eliminar(Convert.ToInt32(cmbEstructurasRamificadas.SelectedItem));
                SeleccionRecorrido();
                RecorrerElementos();


                if (Arbol.Raiz == null)
                {
                    File.Delete("./Hola.csv");
                    dgvGrilla.Rows.Clear();
                    cmbEstructurasRamificadas.Items.Clear();
                    ltsLista.Items.Clear();
                    TVarbolbinario.Nodes.Clear();

                }

            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigo.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Arbol.Busqueda(Convert.ToInt32(txtCodigo.Text)) == false)
            {
                Nodo objNodo = new Nodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;
                StreamWriter Sw = new StreamWriter("./Hola.csv", true);

                Arbol.agregar(objNodo);

                if (btnInOden.Checked)
                {

                    Arbol.Recorrer(dgvGrilla);
                    Arbol.Recorrer(ltsLista);
                    Arbol.Recorrer(cmbEstructurasRamificadas);
                    Arbol.Recorrer(TVarbolbinario);
                    Arbol.RecorrerSW(Sw);
                    txtCodigo.Focus();






                }
                if (btnAscendente.Checked)
                {
                    Arbol.Recorrer(ltsLista);
                    Arbol.Recorrer(dgvGrilla);
                    Arbol.Recorrer(cmbEstructurasRamificadas);
                    Arbol.Recorrer(TVarbolbinario);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigo.Focus();



                }
                else
                {
                    Arbol.RecorrerDes(ltsLista);
                    Arbol.RecorrerDes(dgvGrilla);
                    Arbol.RecorrerDes(cmbEstructurasRamificadas);
                    Arbol.RecorrerDes(TVarbolbinario);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigo.Focus();

                }
                if (btnPreOrden.Checked)
                {
                    Arbol.RecorrerPreOrden(dgvGrilla);
                    Arbol.RecorrerPreOrden(ltsLista);
                    Arbol.RecorrerPreOrden(cmbEstructurasRamificadas);
                    Arbol.RecorrerPreOrden(TVarbolbinario);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigo.Focus();


                }
                if (btnPosOrden.Checked)
                {
                    Arbol.RecorrerPostOrden(dgvGrilla);
                    Arbol.RecorrerPostOrden(ltsLista);
                    Arbol.RecorrerPostOrden(cmbEstructurasRamificadas);
                    Arbol.RecorrerPostOrden(TVarbolbinario);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigo.Focus();

                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                Sw.Close();
                Sw.Dispose();
            }
            else
            {
                MessageBox.Show("este codigo ya existe, intente otro");
            }

        }


        public void RecorrerElementos()
        {
            if (Arbol.Raiz != null)
            {
                StreamWriter sw = new StreamWriter("./REPORTE.txt", false);
                Arbol.Recorrer(sw, asc, recorrer);
                sw.Close();
                sw.Dispose();
                Arbol.Recorrer(ltsLista, asc, recorrer);
                Arbol.Recorrer(cmbEstructurasRamificadas, asc, recorrer);
                Arbol.Recorrer(dgvGrilla, recorrer, asc);
                Arbol.Recorrer(TVarbolbinario);
                TVarbolbinario.ExpandAll();


            }
        }

        public void SeleccionRecorrido()
        {
            if (btnInOden.Checked)
            {
                recorrer = "InOrden";
                if (btnAscendente.Checked)
                {
                    asc = true;
                }
                else if (btnDescendente.Checked)
                {
                    asc = false;
                }
            }
            else if (btnPosOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (btnPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }

        }


    }
}
