using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimple
{
    public class Lista
    {
        public Nodo empiezo;
        public Nodo termino;

        public Lista()
        {
            this.empiezo = null;
            this.termino = null;

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
        }

        public void RecorrerLista()
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
                    Console.Write("{0}->", trabajo.dato);
                    trabajo = trabajo.siguiente;
                }

                Console.Write("null");
            }
        }
    }

    
}
