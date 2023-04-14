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
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila cola = new frmPila();
            cola.ShowDialog();
        }
    }
}
