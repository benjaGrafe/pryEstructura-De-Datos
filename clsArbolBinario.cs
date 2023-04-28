using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                //afuera del while

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
    }
}
