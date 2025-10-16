using System;
using System.Runtime.CompilerServices;

namespace PokemonsPOO
{
    public class Caracteristicas
    {
        private string nombrePokemon;
        private string regionPokemon;
        private int nivelPokemon;
        private double saludPokemon;
        private double saludMaxima;
        private int nivelMaximo;
        private TipoPokemon tipoPokemon;

        public string NombrePokemon
        {
            get => nombrePokemon;
            set => nombrePokemon = value;
        }

        public string RegionPokemon
        {
            get => regionPokemon;
            set => regionPokemon = value;
        }

        public int NivelPokemon
        {
            get => nivelPokemon;
            set
            {
                if (value < 0)
                {
                    nivelPokemon = 0;
                }
                else
                {
                    nivelPokemon = value;
                }
            }
        }

        public double SaludPokemon
        {
            get => saludPokemon;
            set
            {
                if (value < 0.0)
                {
                    saludPokemon = 0.0;
                    Console.WriteLine("La salud debe ser mayor o igual a 0. Se ha establecido a 0.");
                }
                else
                {
                    saludPokemon = value;
                }
            }
        }

        public double SaludMaxima
        {
            get => saludMaxima;
            set
            {
                if (value < 0.0)
                {
                    saludMaxima = 0.0;
                    Console.WriteLine("La salud debe ser mayor o igual a 0. Se ha establecido a 0.");
                }
                else
                {
                    saludMaxima = value;
                }
            }
        }

        public int NivelMaximo
        {
            get => nivelMaximo;
            set
            {
                if (value < 0)
                {
                    nivelMaximo = 0;
                    Console.WriteLine("La salud debe ser mayor o igual a 0. Se ha establecido a 0.");
                }
                else
                {
                    nivelMaximo = value;
                }
            }
        }

        public TipoPokemon TipoPokemon
        {
            get => tipoPokemon;
            set => tipoPokemon = value;
        }

        public Caracteristicas(string nombreP, string regioP, int pokeLvl, double pokeSalud, TipoPokemon tipo)
        {
            NombrePokemon = nombreP;
            RegionPokemon = regioP;
            NivelPokemon = pokeLvl;
            SaludPokemon = pokeSalud;
            TipoPokemon = tipo;
        }

        public Caracteristicas(string nombreP, TipoPokemon tipo) : this(nombreP, "Desconocida", 1, 10.0, tipo)
        {

        }

        public void EvolucionarPokemon()
        {
            nivelPokemon++;
            Console.WriteLine($"Pokemon {nombrePokemon} a evolucionado {nivelPokemon} lvl");
        }

        public void CurarPokemon()
        {
            SaludPokemon = SaludMaxima;
        }

        public void EvolucionarMax()
        {
            NivelPokemon = NivelMaximo;
        }

        public class Pokedex
        {
            private List<Caracteristicas> Pokemons = new List<Caracteristicas>();
            private List<TipoPokemon> TiposDePokemons = new List<TipoPokemon>();

            public void aggPokemon(Caracteristicas pokemon)
            {
                Pokemons.Add(pokemon);
                Console.WriteLine($"SE agg el pokemon {pokemon.NombrePokemon}");
            }

            public List<Caracteristicas> ObtenerTodos()
            {
                return Pokemons;
            }

            public void MostrarTodos ()
            {
                Console.WriteLine("\nPokedex\n");
                foreach(var pokemon in Pokemons)
                {
                    Console.WriteLine($"Nombre: {pokemon.NombrePokemon}\n" +
                        $"Tipo: {pokemon.TipoPokemon}\n" +
                        $"Nivel: {pokemon.NivelPokemon}\n" +
                        $"Region: {pokemon.RegionPokemon}\n");
                }
            }

            public List<TipoPokemon> ObtenerTiposDisponibles()
            {
                return TiposDePokemons;
            }

            public void MostrarTiposDisponibles()
            {
                Console.WriteLine("Los tipos disponibles son");
                foreach(var disponibles in TiposDePokemons)
                {
                    Console.WriteLine(disponibles);
                }
            }
        }
    }
}