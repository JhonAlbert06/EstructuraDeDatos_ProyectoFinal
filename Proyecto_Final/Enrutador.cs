using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final
{
    class Enrutador
    {
        
        private Nodo Raiz;

        public Enrutador()
        {
            Raiz = null;
        }

        public Enrutador(Nodo R)
        {
            Raiz = R;
        }

        Pila_Recibidos Pila = new Pila_Recibidos();
        int X;

        public void Enviar_Paquetes(Nodo r, Nodo P)
        {
            
            if (r != null)
            {
                X = r.Visitar(P, r);
                Nodo aux = new Nodo(X);
                Pila.Insertar_Nodo(aux);
                Enviar_Paquetes(r.Puerto_1, P);
                Enviar_Paquetes(r.Puerto_2, P);
                Enviar_Paquetes(r.Puerto_3, P);
                Enviar_Paquetes(r.Puerto_4, P);
                Enviar_Paquetes(r.Puerto_5, P);
                Enviar_Paquetes(r.Puerto_6, P);
                Enviar_Paquetes(r.Puerto_7, P);
                Enviar_Paquetes(r.Puerto_8, P);
            }

        }

        public Nodo Retornar_Pila()
        {
            return Pila.Eliminar_Nodo();
        }

        public void setRaiz(Nodo r)
        {
            Raiz = r;
        }
        public Nodo getRaiz()
        {
            return Raiz;
        }

        public Nodo raizArbol()
        {
            if (Raiz != null)
                return Raiz;
            else
                throw new Exception(" arbol vacío");
        }
        public bool esVacio()
        {
            return Raiz == null;
        }

        public Nodo Puerto_1()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_1;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_2()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_2;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_3()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_3;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_4()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_4;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_5()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_5;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_6()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_6;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_7()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_7;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo Puerto_8()
        {
            if (Raiz != null)
            {
                return Raiz.Puerto_8;
            }
            else
            {
                throw new Exception("Arbol vacío");
            }
        }

        public Nodo nuevoArbol(Nodo P_1, Nodo P_2, Nodo P_3, Nodo P_4, int dato, Nodo P_5, Nodo P_6, Nodo P_7, Nodo P_8)
        {
            return new Nodo(dato,P_1,P_2,P_3,P_4,P_5,P_6,P_7,P_8);
        }
    }
}
