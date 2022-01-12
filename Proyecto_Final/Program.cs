using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("\t\tEnrutador\n");
            Console.WriteLine("\nJhon Albert Guzman Rosario  2019-0430");

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");

            Enrutador Router = new Enrutador();

            Nodo N1, N2, N3, N4, N5, N6, N7, N8;
            Nodo Raiz, NN1, NN2, NN3, NN4, NN5, NN6, NN7, NN8;

            Console.Write("\n\nPulse cualquier tecla para empezar: ");
            Console.ReadKey();

            Console.WriteLine("\n\nGenerando Red de routers....");

            N1 = Router.nuevoArbol(null, null, null, null, 101, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 102, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 103, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 104, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 105, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 106, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 107, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 108, null, null, null, null);
            NN1 = Router.nuevoArbol(N1, N2, N3, N4, 1, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 201, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 202, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 203, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 204, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 205, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 206, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 207, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 208, null, null, null, null);
            NN2 = Router.nuevoArbol(N1, N2, N3, N4, 2, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 301, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 302, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 303, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 304, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 305, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 306, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 307, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 308, null, null, null, null);
            NN3 = Router.nuevoArbol(N1, N2, N3, N4, 3, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 401, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 402, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 403, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 404, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 405, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 406, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 407, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 408, null, null, null, null);
            NN4 = Router.nuevoArbol(N1, N2, N3, N4, 4, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 501, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 502, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 503, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 504, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 505, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 506, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 507, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 508, null, null, null, null);
            NN5 = Router.nuevoArbol(N1, N2, N3, N4, 5, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 601, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 602, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 603, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 604, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 605, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 606, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 607, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 608, null, null, null, null);
            NN6 = Router.nuevoArbol(N1, N2, N3, N4, 6, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 701, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 702, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 703, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 704, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 705, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 706, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 707, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 708, null, null, null, null);
            NN7 = Router.nuevoArbol(N1, N2, N3, N4, 7, N5, N6, N7, N8);

            N1 = Router.nuevoArbol(null, null, null, null, 801, null, null, null, null);
            N2 = Router.nuevoArbol(null, null, null, null, 802, null, null, null, null);
            N3 = Router.nuevoArbol(null, null, null, null, 803, null, null, null, null);
            N4 = Router.nuevoArbol(null, null, null, null, 804, null, null, null, null);
            N5 = Router.nuevoArbol(null, null, null, null, 805, null, null, null, null);
            N6 = Router.nuevoArbol(null, null, null, null, 806, null, null, null, null);
            N7 = Router.nuevoArbol(null, null, null, null, 807, null, null, null, null);
            N8 = Router.nuevoArbol(null, null, null, null, 808, null, null, null, null);
            NN8 = Router.nuevoArbol(N1, N2, N3, N4, 8, N5, N6, N7, N8);

            Raiz = Router.nuevoArbol(NN1, NN2, NN3, NN4, 0, NN5, NN6, NN7, NN8);

            Router.setRaiz(Raiz);

            Console.WriteLine("\nRed de routers generados correctamente....");
            Console.WriteLine("\nSe ha generado una red que cuentanta con tres Niveles: ");
            Console.WriteLine("\n-Un Router raiz\n-Ocho Sub-Routers y estos a su vez con ocho conecciones cada uno.");

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");

            Console.Write("\n\nPulse Enter para continuar: ");
            Console.ReadKey();

            Console.WriteLine("\n\nGenerando Paquetes....");
            
            Random random = new Random();
            Nodo Paquete;

            Cola_Paquetes Cola = new Cola_Paquetes();

            for (int i = 0; i < 3; i++)
            {

                Paquete = Router.nuevoArbol(null, null, null, null, random.Next(100, 805), null, null, null, null);
                Cola.Insertar_Nodo_Prioridad(Paquete, random.Next(0, 5));
                Console.WriteLine($"\nIngresado paquete #{i + 1} en la cola de Paquetes...");


            }

            Console.WriteLine("\nPaquetes generados correctamente....");

            Console.Write("\nLista de Paquetes: ");
            Cola.Mostrar_Lista();

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");

            Console.Write("\n\nPulse Enter para enviar Paquetes: ");
            Console.ReadKey();

            Console.WriteLine("\n\nTratando de enviar Primer Paquete Paquete...");

            Nodo aux = Cola.Eliminar_Primer_Nodo();
            
            Router.Enviar_Paquetes(Raiz,aux);

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");

            Console.Write("\n\nPulse Enter para enviar el siguiente Paquete: ");
            Console.ReadKey();

            Console.WriteLine("\n\nTratando de enviar Segundo Paquete Paquete...");

            aux = Cola.Eliminar_Primer_Nodo();

            Router.Enviar_Paquetes(Raiz, aux);

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");

            Console.Write("\n\nPulse Enter para enviar el siguiente Paquete: ");
            Console.ReadKey();

            Console.WriteLine("\n\nTratando de enviar Tercer Paquete Paquete...");

            aux = Cola.Eliminar_Primer_Nodo();

            Router.Enviar_Paquetes(Raiz, aux);

            Console.Write("\n-------------------------------------------------------------------------------------------------------\n");


            Console.Write("\n\nPulse cualquier tecla para ver la pila de paquetes recibidos: ");
            Console.ReadKey();

            Console.WriteLine("\nPila de Paquetes Recibidos\n");

            for(int i = 0; i < 3; i++)
               Console.WriteLine(Router.Retornar_Pila().dato);

        }
    }
}
