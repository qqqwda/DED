using System;

namespace ListaEnlazadaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();

            l.agregarNodo(3);
            l.agregarNodo(4);
            l.agregarNodo(5);
            l.agregarNodo(6);
            l.agregarNodo(7);
            l.agregarNodo(8);
            l.agregarNodo(9);

            l.RecorrerLista();
            Console.ReadKey();
        }
    }
}
