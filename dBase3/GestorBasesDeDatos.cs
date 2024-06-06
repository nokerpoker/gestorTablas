using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dBase3
{
    class GestorBasesDeDatos
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1 - Crear Tabla." +
                                "\n2 - Añadir datos a la tabla." + 
                                "\n3 - salir." + 
                                "\nElige una opción: ");
            ElegirOpcionMenu();
            Console.Clear();
        }

        public static void ElegirOpcionMenu()
        {
            int opcion;
            do 
            { 
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CreadorDeTablas crearTabla = new CreadorDeTablas();
                        crearTabla.EjecutarCreadorTablas();
                        break;
                    case 2:
                        InsertadorEnTablas insertarTabla = new InsertadorEnTablas();
                        insertarTabla.EjecutarInsertarTablas();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa.");
                        Environment.Exit(3);
                        break;
                        default:
                    Console.WriteLine("Opción no válida, inténtelo de nuevo.");
                        break;
                }
            } while (opcion != 3);
        }
    }
}
