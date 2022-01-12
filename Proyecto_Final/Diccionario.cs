using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class Diccionario
    {
        public struct Lineas
        {
            public string Palabra;
            public int Definicion;
        }

        public string Palabra
        {
            get; set;
        }

        public int Definicion
        {
            get; set;
        }

        protected bool _esAlta;

        public bool esAlta
        {
            get
            {
                return _esAlta;
            }
        }

        public Diccionario()
        {
            Palabra = " ";
            Definicion = 0;
        }

        public Diccionario(Lineas c)
        {
            _esAlta = true;
            asigna(c);
        }

        public void EliminarPalabra()
        {
            _esAlta = false;
        }

        public void Muestra()
        {
            Console.WriteLine($"Palabra: {Palabra}.");
            Console.WriteLine($"Definicion: {Definicion}.");
        }

        public void asigna(Lineas c)
        {
            this.Palabra = c.Palabra;
            this.Definicion = c.Definicion;
        }


    }
}
