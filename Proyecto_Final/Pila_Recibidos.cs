using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class Pila_Recibidos
    {

        private Nodo0 Cima = new Nodo0();

        public Pila_Recibidos()
        {
            Cima = null;
        }

        public void Insertar_Nodo(Nodo dato)
        {
            Nodo0 Nuevo_Nodo = new Nodo0();

            Nuevo_Nodo.dato = dato;

            Nuevo_Nodo.siguiente = Cima;
            Cima = Nuevo_Nodo;

        }

        public Nodo Eliminar_Nodo()
        {
            Nodo0 aux = Cima;

            Cima = Cima.siguiente;
            aux.siguiente = null;

            return aux.dato;
        }


    }
}
