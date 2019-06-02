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

        public void buscarNodo(int numero)
        {
            Nodo trabajo = empiezo;
            int pos = 0;
            while (trabajo.dato != numero)
            {
                pos++;
                trabajo = trabajo.siguiente;
            }

            Console.WriteLine("Se encontró: {0} en la posición: {1}",trabajo.dato,pos);
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

                Console.WriteLine("null");
            }
        }
    }

    
}
