using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class Nodo
    {

        public int dato { get; set; }

        public Nodo Puerto_1 { get; set; }
        public Nodo Puerto_2 { get; set; }
        public Nodo Puerto_3 { get; set; }
        public Nodo Puerto_4 { get; set; }
        public Nodo Puerto_5 { get; set; }
        public Nodo Puerto_6 { get; set; }

        public Nodo Puerto_7 { get; set; }

        public Nodo Puerto_8 { get; set; }

        public Nodo (int valor)
        {
            dato = valor;
            Puerto_1 = null;
            Puerto_2 = null;
            Puerto_3 = null;
            Puerto_4 = null;
            Puerto_5 = null;
            Puerto_6 = null;
            Puerto_7 = null;
            Puerto_8 = null;
        }

        public Nodo(int valor, Nodo puerto_1, Nodo puerto_2, Nodo puerto_3, Nodo puerto_4, Nodo puerto_5, Nodo puerto_6, Nodo puerto_7, Nodo puerto_8)
        {
            dato = valor;
            Puerto_1 = puerto_1;
            Puerto_2 = puerto_2;
            Puerto_3 = puerto_3;
            Puerto_4 = puerto_4;
            Puerto_5 = puerto_5;
            Puerto_6 = puerto_6;
            Puerto_7 = puerto_7;
            Puerto_8 = puerto_8;
        }

        public int Visitar(Nodo p, Nodo r)
        {
            Console.WriteLine("\nTratando de Enviar Paquete...");
            
            while(p.dato != r.dato)
            {
                Console.WriteLine("Paquete rechazado...");
                return 0;
            }

            if (p.dato == r.dato)
            {
                Console.WriteLine("Paquete recibido perfectamete...");
                return p.dato;
            }

            return 0;
        }

        public bool senal(int x)
        {
            return (x != 0) ? true : false;
        }


    }
}
