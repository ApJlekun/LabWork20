using Microsoft.AspNetCore.Mvc;
using Task1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        /*static List<Category> Categories = new List<Category>
        {
            new Category{Id = 1, Name = "головоломка", Description = "описание жанра головоломка"},
            new Category{Id = 2, Name = "платформер", Description = "описание жанра платформер"},
            new Category{Id = 3, Name = "RPG", Description = "описание жанра RPG"},
            new Category{Id = 4, Name = "аркада", Description = "описание жанра аркада"}
        };

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return Categories;
        }

        [HttpGet("{name}")]
        public IEnumerable<Category> Get(string name)
        {
            return Categories.Where(category => category.Name == name);
        }

        [HttpGet("{id:int}")]
        public Category Get(int id)
        {
            return Categories.FirstOrDefault(category => category.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var category = Categories.FirstOrDefault(c => c.Id == id);
            Categories.Remove(category);
        }*/
    }
}
