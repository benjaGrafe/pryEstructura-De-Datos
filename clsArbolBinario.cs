using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    internal class clsArbolBinario
    {
        private Nodo Inicio;

        private Nodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void agregar(Nodo nvo)
        {
            nvo.Izquierdo = null;
            nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                Nodo NodoPadre = Raiz;
                Nodo Aux = Raiz;

                while (Aux != null)
                {
                    NodoPadre = Aux;

                    if (nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }



                if (nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = nvo;
                }
                else
                {
                    NodoPadre.Derecho = nvo;

                }


            }


        }


        public void InOrdenAsc(ListBox lista, Nodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(lista, R.Izquierdo);

            }
            lista.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(lista, R.Izquierdo);
            }


        }

        public void preOrdenAsc(ListBox lista, Nodo R)
        {
            if (R.Izquierdo != null)
                preOrdenAsc(lista, R.Izquierdo);
            if (R.Derecho != null) preOrdenAsc(lista, R.Izquierdo);
        }
        public void posOrdenAsc(ListBox lista, Nodo R)
        {
            if (R.Izquierdo != null) posOrdenAsc(lista, R.Izquierdo);
            if (R.Derecho != null) posOrdenAsc(lista, R.Izquierdo);
            lista.Items.Add(R.Codigo);
        }


        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenAsc(lista, Raiz);

        }

        private Nodo[] vector = new Nodo[100];
        private Int32 i = 0;

        public void equilibrar()
        {
            i = 0;
            CargavectorInOrden(Raiz);
            Raiz = null;
            equilibrarArbol(0, i - 1);
        }

       private void CargavectorInOrden (Nodo Nodopadre)
       {
            if (Nodopadre.Izquierdo != null) 
            {
                CargavectorInOrden(Nodopadre.Izquierdo);
            }
            vector[i] = Nodopadre;
            i ++;
            if(Nodopadre.Derecho != null)
            {
                CargavectorInOrden(Nodopadre.Derecho);
            }


       }
        
        private void equilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= 0)
            {
                agregar(vector[m]);
                equilibrarArbol(ini, m -  1);
                equilibrarArbol( m + 1, fin);
            }
        }

        

    }
}
