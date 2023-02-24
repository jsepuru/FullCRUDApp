using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullCRUDApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic> {
        new Comic { ComicId = 1, ComicName = "Marvel" },
        new Comic { ComicId = 2 , ComicName = "DC"}
        };

        public static List<SuperHero> heros = new List<SuperHero>
        {
            new SuperHero
            {
                HeroId = 1,
                FirstName = "Peter",
                LastName = "Paker",
                HeroName = "Spiderman",
                comic = comics[0]
            },
            new SuperHero
            {
                HeroId = 1,
                FirstName = "Bruce",
                LastName = "Wayne",
                HeroName = "Batman",
                comic = comics[1]
            }

        };

    }

}
