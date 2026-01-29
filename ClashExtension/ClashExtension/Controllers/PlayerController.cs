using Microsoft.AspNetCore.Mvc;
using Clash.Domain.Models;
using System.Text.Json;

namespace ClashExtensionAPI.Controllers
{
    [Route("api/Player")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly HttpClient _http;
        public PlayerController(IHttpClientFactory http)
        {
            _http = http.CreateClient("coc");
        }

        [HttpGet("players/{playerTag}")]
        public async Task<Player> GetPlayer(string playerTag)
        {
            var uri = "https://api.clashofclans.com/v1/players/%23" + playerTag;
            var response = await _http.GetStringAsync(uri);
            var desirialized = JsonSerializer.Deserialize<Player>(response);
            var name = desirialized.Name;
            Player player = new Player  
            {
                Name = desirialized.Name,
                Tag = desirialized.Tag,
                TownHallLevel = desirialized.TownHallLevel
            };

            return player;
        }
    }
}
