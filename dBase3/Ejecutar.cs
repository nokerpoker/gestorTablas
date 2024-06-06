using dBase3;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            GestorBasesDeDatos.MostrarMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
