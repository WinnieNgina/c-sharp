using Microsoft.AspNetCore.Mvc;
using pokerReview.Interfaces;
using pokerReview.Models;
using pokerReview.Repository;

namespace pokerReview.Controllers
{
    [Route("api/[controller]")]
    //specify route
    [ApiController]
    //specifies its an API simplifying some common API-related behaviour
    public class PokemonController : Controller
    //inherits from controller class of the framework which handle HTTP requests and returns appropriate responses
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
            // consrtuctor used to create and intilialize Pokemon Controller
        {
            _pokemonRepository = pokemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<Pokemon>))]
        // Specifies the response type and status code of GettPokemons method
        public IActionResult GetPokemons () 
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemons);
        }
        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId) 
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();
            var Pokemon = _pokemonRepository.GetPokemon(pokeId);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(Pokemon);
        }
        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type= typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonRating(int pokeId) 
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();
            var rating = _pokemonRepository.GetPokemonRating(pokeId);
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(rating);
        }

    }
}
