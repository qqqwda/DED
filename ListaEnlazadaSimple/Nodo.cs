using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimple
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
        public int index;

        public int Dato { get { return dato; } set { value = dato; } }
        public Nodo Siguiente { get { return siguiente; } set { value = siguiente; } }

        public Nodo(int d)
        {
            this.dato = d;
            this.siguiente = null;
        }


    }
}
