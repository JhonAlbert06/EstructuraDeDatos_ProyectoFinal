using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class TablaDispersa
    {
        private int _tamanoTabla;
        protected int numElementos;
        protected double factorCarga;

        protected Diccionario[] tabla;

        public TablaDispersa(int TamanoTabla)
        {
            _tamanoTabla = TamanoTabla;
            tabla = new Diccionario[TamanoTabla];

            for (int i = 0; i < TamanoTabla; i++)
            {
                tabla[i] = null;
            }

            numElementos = 0;
            factorCarga = 0.0;
        }

        public int FuncionHash(string clave)
        {

            int i = 0;
            long p, d;

            d = TransformaCadena(clave);

            p = d % _tamanoTabla;

            while (tabla[p] != null && !tabla[p].Palabra.Equals(clave))
            {

                i++;
                p = p + i * i;
                p = p % _tamanoTabla;

            }

            return (int)p;
        }


        public void Insertar(Diccionario.Lineas t)
        {
            int posicion;

            posicion = FuncionHash(t.Palabra);

            tabla[posicion] = new Diccionario(t);

            numElementos++;

            factorCarga = (double)numElementos / _tamanoTabla;

            if (factorCarga > 0.7)
            {

                Console.WriteLine("\n!! Factor de carga supera el 70 por 100.!!");
                Console.WriteLine(" Conviene aumentar el tamaño.");

            }

        }

        public Diccionario Buscar(string clave)
        {

            Diccionario palabraD;

            int posicion;

            posicion = FuncionHash(clave);

            palabraD = tabla[posicion];

            if (palabraD != null)
                if (!palabraD.esAlta) palabraD = null;

            return palabraD;
        }

        private void Eliminar(string clave)
        {

            int posicion;

            posicion = FuncionHash(clave);

            if (tabla[posicion] != null)
                tabla[posicion].EliminarPalabra();

        }

        private long TransformaCadena(string c)
        {
            long d = 0;

            for (int j = 0; j < c.Length; j++)
            {
                d = d * 27 + (int)c[j];
            }

            if (d < 0)
                d = -d;

            return d;
        }

    }
}
