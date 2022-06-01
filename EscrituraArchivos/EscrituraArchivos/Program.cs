using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            //si el archivo no existe lo creara o en el caso de que exista lo sobrescribe

            string[] lines =
            {
                "Esto es la primera linea",
                "Esto es la segunda linea",
                "Esto es la tercer linea"
            };
            //recorre el arreglo para escribir las lineas en el archivo
            foreach (string line in lines)
            {
                //escribir en el archivo
                sw.WriteLine(line);
            }

            //cerrar el archivo
            sw.Close();

            Console.WriteLine("Escribiendo .... ");
            Console.ReadLine();
        }
    }
}
