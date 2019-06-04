using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimple
{
    public class Lista
    {
        public Nodo empiezo;
        public Nodo termino;
        public int largo;

        public Lista()
        {
            this.empiezo = null;
            this.termino = null;

        }


        public int determinarLargo()
        {
            Nodo trabajo = empiezo;
            largo = -1;
            while (trabajo != null)
            {
                largo++;
                trabajo = trabajo.siguiente;
            }
            return largo;
        }

        

        public Nodo buscarNodo(int numero)
        {
            Nodo trabajo = empiezo;

            while (trabajo.dato != numero)
            {
                trabajo = trabajo.siguiente;
            }

            return trabajo;
        }

       


        public void agregarNodo(int numero)
        {
            Nodo nodoNuevo = new Nodo(numero);
            if(empiezo == null)
            {
                empiezo = nodoNuevo;
                termino = nodoNuevo;
            }
            else
            {
                termino.siguiente = nodoNuevo;
                termino = termino.siguiente;
            }
            determinarLargo();
            determinarIndex(termino);
        }

        private void determinarIndex(Nodo termino)
        {
            termino.index = determinarLargo();
        }

        public void eliminarIndex(int index)
        {
            Nodo trabajo = empiezo;
            while (index != trabajo.index)
            {
                trabajo = trabajo.siguiente;
            }
        }

        public void recorrerLista()
        {
            Nodo trabajo = empiezo;

            if (trabajo == null)
            {
                Console.WriteLine("No hay nodos");
            }
            else
            {
                while (trabajo != null)
                {
                    Console.WriteLine("Index {0}:[{1}]",trabajo.index,trabajo.dato);
                    Console.WriteLine();
                    trabajo = trabajo.siguiente;
                }

                Console.WriteLine("null");
            }
        }

        public Nodo getIndex(int index)
        {
            Nodo trabajo = empiezo;
            while (trabajo.index != index)
            {
                trabajo = trabajo.siguiente;
            }

            return trabajo;
        }
        




    }

    
}
