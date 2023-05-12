using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_De_Datos
{
    internal class clsArbolBinario
    {
        private Nodo Inicio;

        public Nodo Raiz
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
        //inorden ascendente
        //grilla


        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenAsc(lista, Raiz);
        }


        public void InOrdenAsc(ListBox lista, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lista, R.Izquierdo);
            lista.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lista, R.Izquierdo);
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

        //grilla
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }


        public void InOrdenAsc(DataGridView Grilla, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Izquierdo);
        }

        //combobox


        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenAsc(cmb, Raiz);
        }


        public void InOrdenAsc(ComboBox cmb, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(cmb, R.Izquierdo);
        }


        //streamwriter

        public void RecorrerSW(StreamWriter sw)
        {
            InOrdenAsc(sw, Raiz);
        }

        public void InOrdenAsc(StreamWriter sw, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(sw, R.Izquierdo);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Derecho != null) InOrdenAsc(sw, R.Derecho);
        }


        // TreeView -------
        public void Recorrer(TreeView trv)
        {
            trv.Nodes.Clear();
            InOrdenAsc(trv.Nodes, Raiz);
        }

        public void InOrdenAsc(TreeNodeCollection nodoPadre, Nodo Raiz)
        {
            TreeNode nodonuevo = nodoPadre.Add(Raiz.Codigo.ToString());
            if (Raiz.Izquierdo != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Izquierdo);

            if (Raiz.Derecho != null) InOrdenAsc(nodonuevo.Nodes, Raiz.Derecho);
        }


        //INORDEN DESCENDENTE
        //---------------------------------------------------------------------------------------------------------
        public void RecorrerDes(ListBox Lst)
        {
            Lst.Items.Clear();
            InOrdenDes(Lst, Raiz);
        }

        public void InOrdenDes(ListBox lst, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
        }

        // combobox
        public void RecorrerDes(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenDes(cmb, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
        }


        // datagridview 
        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
        }


        // treamwriter
        public void RecorrerDesSW(StreamWriter sw)
        {
            InOrdenDes(sw, Raiz);
        }

        public void InOrdenDes(StreamWriter Sw, Nodo R)
        {
            if (R.Derecho != null) InOrdenDes(Sw, R.Derecho);
            Sw.Write(R.Codigo);
            Sw.Write(";");
            Sw.Write(R.Nombre);
            Sw.Write(";");
            Sw.WriteLine(R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(Sw, R.Izquierdo);
        }


        // treeview
        public void RecorrerDes(TreeView trv)
        {
            trv.Nodes.Clear();
            InOrdenDes(trv.Nodes, Raiz);
        }

        public void InOrdenDes(TreeNodeCollection NodoPadre, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(NodoPadre, R.Derecho);
            TreeNode nodoNuevo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(NodoPadre, R.Izquierdo);
        }

        //PREORDEN
        // ListBox 
        public void RecorrerPreOrden(ListBox Lst)
        {
            Lst.Items.Clear();
            PreOrden(Lst, Raiz);
        }

        public void PreOrden(ListBox lst, Nodo R)
        {
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }


        // ComboBox 
        public void RecorrerPreOrden(ComboBox Cmb)
        {
            Cmb.Items.Clear();
            PreOrden(Cmb, Raiz);
        }

        public void PreOrden(ComboBox Combo, Nodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }


        // DataGridView 
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void PreOrden(DataGridView Grilla, Nodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }


        // StreamWriter 
        public void RecorrerPreOrdenSW(StreamWriter stw)
        {
            PreOrden(stw, Raiz);
        }
        public void PreOrden(StreamWriter sw, Nodo R)
        {
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(sw, R.Izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
        }


        // TreeView 
        public void RecorrerPreOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PreOrden(treeView.Nodes, Raiz);
        }

        public void PreOrden(TreeNodeCollection Npadre, Nodo R)
        {
            TreeNode nodoNuevo = Npadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);
        }


        //POSTORDEN
        // listbox
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        public void PostOrden(ListBox lst,Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }


        // combobox 
        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(ComboBox Combo, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }


        // datagridview 
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        public void PostOrden(DataGridView Grilla,Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        // streamwriter 
        public void RecorrerPostOrdenSW(StreamWriter sw)
        {
            PostOrden(sw, Raiz);
        }
        public void PostOrden(StreamWriter sw, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenDes(sw, R.Izquierdo);
            if (R.Derecho != null) InOrdenDes(sw, R.Derecho);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
        }


        //treeview 
        public void RecorrerPostOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PostOrden(treeView.Nodes, Raiz);
        }

        public void PostOrden(TreeNodeCollection Npadre, Nodo R)
        {
            TreeNode nodoNuevo = Npadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(nodoNuevo.Nodes, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(nodoNuevo.Nodes, R.Derecho);
        }
















        //eliminar

        private Nodo[] vector = new Nodo[100];
        private Int32 i = 0;
        private int eliminarNodos;


        public void equilibrar()
        {
            i = 0;
            CargavectorInOrden(Raiz);
            Raiz = null;
            equilibrarArbol(0, i - 1);
        }

        public void Equilibrar(int Nodo)
        {
            eliminarNodos = Nodo;
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

        public void Eliminar(Int32 Codigo)
        {
            Raiz = EliminarNodos(Raiz, Codigo);
        }

        private Nodo EliminarNodos(Nodo NodoActual, Int32 Codigo)
        {
            if (NodoActual == null)
            {
                return null;
            }
            if (Codigo < NodoActual.Codigo)
            {
                NodoActual.Izquierdo = EliminarNodos(NodoActual.Izquierdo, Codigo);
            }
            else if (Codigo > NodoActual.Codigo)
            {
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, Codigo);
            }
            else
            {
                if (NodoActual.Izquierdo == null)
                {
                    return NodoActual.Derecho;
                }
                else if (NodoActual.Derecho == null)
                {
                    return NodoActual.Izquierdo;
                }

                Nodo sucesor = NodoActual.Derecho;
                while (sucesor.Izquierdo != null)
                {
                    sucesor = sucesor.Izquierdo;
                }
                NodoActual.Codigo = sucesor.Codigo;
                NodoActual.Derecho = EliminarNodos(NodoActual.Derecho, sucesor.Codigo);
            }
            return NodoActual;
        }

        //busqueda recursiva

        public bool Busqueda(Int32 Codigo)
        {
            Nodo auxiliar = Raiz;
            while (auxiliar != null && auxiliar.Codigo != Codigo)
            {
                if (Codigo < auxiliar.Codigo)
                {
                    auxiliar = auxiliar.Izquierdo;
                }
                else
                {
                    auxiliar = auxiliar.Derecho;
                }
            }
            if (auxiliar != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //recorridos

        public void Recorrer(ComboBox combo, bool ascedente, string recorrer)
        {
            combo.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(combo, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(combo, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(combo, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(combo, Raiz);
            }
        }
        public void Recorrer(ListBox lst, bool ascedente, string recorrer)
        {
            lst.Items.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(lst, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(lst, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(lst, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(lst, Raiz);
            }
        }
        public void Recorrer(StreamWriter sw, bool ascedente, string recorrer)
        {
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(sw, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(sw, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(sw, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(sw, Raiz);
            }
        }
        public void Recorrer(DataGridView Grilla, string recorrer, bool ascedente)
        {
            Grilla.Rows.Clear();
            if (recorrer == "InOrden")
            {
                if (ascedente == true)
                {
                    InOrdenAsc(Grilla, Raiz);
                }
                else if (ascedente == false)
                {
                    InOrdenDes(Grilla, Raiz);
                }
            }
            else if (recorrer == "PostOrden")
            {
                PostOrden(Grilla, Raiz);
            }
            else if (recorrer == "PreOrden")
            {
                PreOrden(Grilla, Raiz);
            }
        }


    }
}
