using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegatablesController : ControllerBase
    {
        public List<string> vegetables = new List<string>()
        {
            "Aloo",
            "Matr",
            "Pyaaz",
            "Caroot",
            "Gobi",
            "Olive Oil"
        };

        [HttpGet]
        public List<string> GetVegetables()
        {
            return vegetables;
        }

        [HttpGet("{id}")]
        public string GetVegetablesByIndex(int id)
        {
            return vegetables.ElementAt(id);
        }
    }
}
