using Microsoft.AspNetCore.Mvc;
using Jurnal10_103022400043.Models;

namespace Jurnal10_103022400043.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static List<Game> Games = new List<Game>
        {
            new Game
            {
                id = 1,
                nama = "Valorant",
                developer = "Riot Games",
                tahunRilis = 2020,
                genre = "FPS",
                rating = 8.5,
                platform = ["PC"],
                Mode = ["Multiplayer"],
                isOnline = true,
                Harga = 0,
            },
            new Game
            {
                id = 2,
                nama = "GTA V",
                developer = "Rockstar Games",
                tahunRilis = 2013,
                genre = "Open World",
                rating = 9.5,
                platform = ["PC","PS4","PS5","XBOX"],
                Mode = ["Singleplayer"],
                isOnline = true,
                Harga = 300000,
            },
            new Game
            {
                id = 3,
                nama = "The Witcher 3",
                developer = "CD Projekt Red",
                tahunRilis = 2015,
                genre = "RPG",
                rating = 9.7,
                platform = ["PC","PS4","PS5","XBOX"],
                Mode = ["Singleplayer"],
                isOnline = false,
                Harga = 250000,
            },

        };
        //Get : api/game
        [HttpGet]
        public ActionResult<List<Game>> GetAllGame()
        {
            return Ok(Games);
        }
        [HttpGet("{index}")]
        public ActionResult<Game> GetGameByIndex(int index)
        {
            if (index < 0 || index >= Games.Count)
            {
                return NotFound("Game tidak ditemukan");
            }
            return Ok(Games[index - 1]);
        }

        [HttpPost]
        public ActionResult<Game> AddGame([FromBody] Game game)
        {
            Games.Add(game);
            return Ok(game);
        }

        [HttpPut]
        public ActionResult Put(Game updateGame, int id) 
        {
            var index = Games.FindIndex(g => g.id == id);
            if (index == -1) 
            
            {
                return NotFound();

            }
            Games[index] = updateGame;
            return Ok(updateGame);
            
        }

        [HttpDelete("{index}")]
        public ActionResult<string> DeleteGame(int index)
        {
            if (index < 0 || index >= Games.Count) 
            {
                return NotFound("Game Tidak ditemukan");
            }

            Games.RemoveAt(index - 1);
            return Ok("Game Berhasil dihapus");
        }
    }
}
