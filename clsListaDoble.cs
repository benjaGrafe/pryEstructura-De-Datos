using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    internal class clsListaDoble
    {
        //delclaro campos
        private Nodo pri;
        private Nodo ult;

        //declaro las dos propiedades

        public Nodo primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public Nodo ultimo
        {
            get { return ult; }
            set { ult = value;}
                 
        }

        public void agregar(Nodo nvo)
        {
            if (primero == null)
            {
                primero = nvo;
                ultimo = nvo;

            }
            else
            {
                if (nvo.Codigo < primero.Codigo)
                {
                    nvo.Siguiente = primero;
                    primero.anterior = nvo;
                    primero = nvo;
                }
                else
                {
                    if (nvo.Codigo > ultimo.Codigo)
                    {
                        ultimo.Siguiente = nvo;
                        nvo.anterior = ultimo;
                        ultimo = nvo;
                    }
                    else
                    {
                        Nodo aux = primero;
                        Nodo ant = ultimo;

                        while (aux.Codigo < nvo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = nvo;
                        nvo.Siguiente = aux;
                        aux.anterior = nvo;
                        nvo.Siguiente = ant;


                    }


                }


            }



        }

        public void Recorrer(ListBox lista)
        {
            Nodo aux = primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            Nodo aux = primero;
            combo.Items.Clear();
            while(aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            } 

        }

        public void Recorrer (DataGridView grilla)
        {
            Nodo aux = primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux=aux.Siguiente;
            }
        }

       




    }



}

