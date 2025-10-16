using System;
using System.Collections.Generic;

namespace PokemonsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia de la Pokedex
            Caracteristicas.Pokedex miPokedex = new Caracteristicas.Pokedex();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== MENÚ POKÉMON ===");
                Console.WriteLine("1. Crear y agregar Pokémon");
                Console.WriteLine("2. Mostrar todos los Pokémon");
                Console.WriteLine("3. Curar un Pokémon");
                Console.WriteLine("4. Evolucionar un Pokémon");
                Console.WriteLine("5. Evolucionar un Pokémon al máximo");
                Console.WriteLine("6. Mostrar tipos disponibles");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre del Pokémon: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Región del Pokémon: ");
                        string region = Console.ReadLine();

                        Console.Write("Nivel inicial: ");
                        int nivel = int.Parse(Console.ReadLine());

                        Console.Write("Salud inicial: ");
                        double salud = double.Parse(Console.ReadLine());

                        Console.WriteLine("Tipo de Pokémon (Fuego, Agua, Planta, Electrico, etc.): ");
                        string tipoTexto = Console.ReadLine();
                        TipoPokemon tipo;
                        if (!Enum.TryParse(tipoTexto, true, out tipo))
                        {
                            Console.WriteLine("Tipo inválido, se asignará Normal por defecto.");
                            tipo = TipoPokemon.Normal;
                        }

                        var nuevoPokemon = new Caracteristicas(nombre, region, nivel, salud, tipo);
                        miPokedex.aggPokemon(nuevoPokemon);
                        break;

                    case "2":
                        miPokedex.MostrarTodos();
                        break;

                    case "3":
                        Console.Write("Nombre del Pokémon a curar: ");
                        string nombreCurar = Console.ReadLine();
                        var pokeCurar = miPokedex.ObtenerTodos().Find(p => p.NombrePokemon == nombreCurar);
                        if (pokeCurar != null)
                        {
                            pokeCurar.CurarPokemon();
                            Console.WriteLine($"{pokeCurar.NombrePokemon} fue curado.");
                        }
                        else
                        {
                            Console.WriteLine("Pokémon no encontrado.");
                        }
                        break;

                    case "4":
                        Console.Write("Nombre del Pokémon a evolucionar: ");
                        string nombreEvo = Console.ReadLine();
                        var pokeEvo = miPokedex.ObtenerTodos().Find(p => p.NombrePokemon == nombreEvo);
                        if (pokeEvo != null)
                        {
                            pokeEvo.EvolucionarPokemon();
                        }
                        else
                        {
                            Console.WriteLine("Pokémon no encontrado.");
                        }
                        break;

                    case "5":
                        Console.Write("Nombre del Pokémon a evolucionar al máximo: ");
                        string nombreMax = Console.ReadLine();
                        var pokeMax = miPokedex.ObtenerTodos().Find(p => p.NombrePokemon == nombreMax);
                        if (pokeMax != null)
                        {
                            pokeMax.EvolucionarMax();
                        }
                        else
                        {
                            Console.WriteLine("Pokémon no encontrado.");
                        }
                        break;

                    case "6":
                        miPokedex.MostrarTiposDisponibles();
                        break;

                    case "0":
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
