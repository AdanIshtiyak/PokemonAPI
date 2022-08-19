using PokemonAPI.Models;

namespace PokemonAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int pokeId);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRaiting(int pokeId);
        bool PokemonExists(int pokeId);
    }
}
