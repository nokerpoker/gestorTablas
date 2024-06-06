using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dBase3
{
    class CreadorDeTablas
    {
        public void EjecutarCreadorTablas()
        {
            try
            {
                string nombreTabla = PedirString("Nombre de la tabla: ");
                string headerFile = $"{nombreTabla}.header";
                int cantidadCampos = PedirEntero("Cantidad de campos: ");

                List<string> campos = new List<string>();

                for (int i = 0; i < cantidadCampos; i++)
                {
                    string nombreCampo = PedirString("Nombre del campo: ");
                    string tipoDeCampo = PedirString("Tipo de campo: (\"C para un carácter, N para numérico.\"").ToUpper();

                    while (tipoDeCampo != "C" && tipoDeCampo != "N")
                    {
                        Console.WriteLine("Tipo inválido. Por favor, ingrese 'C' para carácter o 'N' para numérico.");
                        tipoDeCampo = PedirString("Tipo de campo: (\"C para un carácter, N para numérico.\"").ToUpper();
                    }

                    int longitudDelCampo = PedirEntero("Longitud del campo: ");

                    campos.Add(nombreCampo + "-" + tipoDeCampo + "-" + longitudDelCampo);
                }

                using(StreamWriter fichero = new StreamWriter(headerFile))
                {
                    fichero.WriteLine(cantidadCampos);
                    foreach (string campo in campos)
                    {
                        fichero.WriteLine(campo);
                    }
                }
                Console.Clear();
                Console.WriteLine("Se ha creado la tabla '{0}'.", nombreTabla);
                Console.WriteLine();
                GestorBasesDeDatos.MostrarMenu();
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string PedirString(string nombre)
        {
            Console.WriteLine(nombre);
            return Console.ReadLine();
        }
        public static int PedirEntero(string cantidad)
        {
            int resultado;
            while (true)
            {
                Console.WriteLine(cantidad);
                if(int.TryParse(Console.ReadLine(), out resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Valor inválido, inténtelo de nuevo.");
                }
            }
        }

    }
}
