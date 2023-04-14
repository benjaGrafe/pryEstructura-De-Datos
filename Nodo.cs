using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructura_De_Datos
{
    internal class Nodo
    {
        //Campos del Nodo
        private Int32 cod;
        private String nom;
        private String tra;
        private Nodo sig;
        private Nodo ant;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}

