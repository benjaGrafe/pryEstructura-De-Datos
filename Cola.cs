using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    internal class Cola
    {

        public Nodo primero;
        public Nodo ultimo;


        public void Agregar(Nodo nuevo)
        {
            if (primero == null) // si el promero no tiene asignado ningun objeto
                                 //entonces le asigna "nuevo", al prinero y segundo 
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }

        }

        public void Eliminar()
        {
            if (primero == ultimo)
            {
                primero = null;//si hubiera un solo obgeto en la cola
                ultimo = null;//estese elimina por lo tanto primero
                              //y ultimo queda en nulo.
            }
            else
            {
                primero = primero.Siguiente;//pero si hubiera otro
                                            //objeto en la cola 
                                            //  le asigna el primero al siguiente

            }

        }
        public void Recorrer(DataGridView Grilla)
        {
            Nodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            Nodo aux = primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            Nodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }

    

}
