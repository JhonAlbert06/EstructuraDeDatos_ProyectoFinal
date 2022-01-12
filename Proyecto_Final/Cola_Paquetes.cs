using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class Cola_Paquetes
    {

        Nodo0 Inicio = new Nodo0();
        Nodo0 Fin = new Nodo0();

        public Cola_Paquetes()
        {
            Inicio = null;
            Fin = null;
        }

        public void Insertar_Nodo_Prioridad(Nodo dato, int prioridad)
        {
            Nodo0 Nuevo_Nodo = new Nodo0();

            Nuevo_Nodo.dato = dato;

            if (Inicio == null)
            {
                Inicio = Nuevo_Nodo;
                Fin = Nuevo_Nodo;
            }
            else
            {
                if (Nuevo_Nodo.Prioridad < Inicio.Prioridad)
                {
                    Nuevo_Nodo.siguiente = Inicio;
                    Inicio = Nuevo_Nodo;
                }
                else
                {
                    Nodo0 aux = Inicio;

                    while (aux.siguiente != null && Nuevo_Nodo.Prioridad >= aux.siguiente.Prioridad)
                    {
                        aux = aux.siguiente;
                    }

                    Nuevo_Nodo.siguiente = aux.siguiente;
                    aux.siguiente = Nuevo_Nodo;

                    if (Nuevo_Nodo.siguiente == null)
                    {
                        Fin = Nuevo_Nodo;
                    }
                }
            }
        }

        public void Insertar_Nodo(Nodo dato)
        {
            Nodo0 Nuevo_Nodo = new Nodo0();

            Nuevo_Nodo.dato = dato;

            if (Inicio == null)
            {
                Inicio = Nuevo_Nodo;
                Fin = Nuevo_Nodo;
            }
            else
            {
                Fin.siguiente = Nuevo_Nodo;
                Fin = Nuevo_Nodo;
            }
        }

        public Nodo Eliminar_Primer_Nodo()
        {
            Nodo0 aux = Inicio;

            Inicio = Inicio.siguiente;
            aux.siguiente = null;

            return aux.dato;
        }

        public void Mostrar_Lista()
        {
            Nodo0 Nuevo_Nodo = new Nodo0();

            Nuevo_Nodo = Inicio;

            if (Inicio != null)
            {
                while (Nuevo_Nodo != null)
                {
                    Console.Write($" {Nuevo_Nodo.dato.dato} ->");

                    Nuevo_Nodo = Nuevo_Nodo.siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La Cola esta Vacia....\n");
            }
        }

    }
}
