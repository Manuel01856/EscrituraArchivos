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
        public class Pokemon
        {
            public string nombre;
            public int num_pokedex;

            public Pokemon(string nombre, int num_pokedex)
            {
                this.nombre = nombre;
                this.num_pokedex = num_pokedex;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Pokedex.txt", true);
            
            Console.Write("Escriba el nombre del pokemon: ");
            string nombre = Console.ReadLine();
            Console.Write("Escriba el número de pokedex: ");
            int num_pokedex = int.Parse(Console.ReadLine());
            
            Pokemon newPokemon = new Pokemon(nombre, num_pokedex);
            
            sw.WriteLine(newPokemon.nombre + " " + newPokemon.num_pokedex);
            sw.Close();
            

            Console.WriteLine("Escribiendo .... ");
            Console.ReadLine();
        }
    }
}
