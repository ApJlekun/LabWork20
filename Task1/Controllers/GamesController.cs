using Microsoft.AspNetCore.Mvc;
using Task1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        static List<Game> Games = new List<Game>
        {
            new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
            new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
            new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
            new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
            new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
            new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return Games;
        }

        [HttpGet("{сategory}")]
        public IEnumerable<Game> Get(string category)
        {
            return Games.Where(game => game.Category == category);
        }

        [HttpGet("{id:int}")]
        public Game Get(int id)
        {
            return Games.FirstOrDefault(game => game.IdGame == id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var game = Games.FirstOrDefault(game => game.IdGame == id);
            Games.Remove(game);
        }

        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/
    }
}
