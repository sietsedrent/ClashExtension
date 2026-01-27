using Microsoft.AspNetCore.Mvc;

namespace ClashExtensionAPI.Controllers
{
    [Route("api/Clans")]
    [ApiController]
    public class ClanController : Controller
    {
        private readonly HttpClient _httpClient;

        public ClanController(IHttpClientFactory _client)
        {
            _httpClient = _client.CreateClient("coc");
        }

        [HttpGet("GetClans")]
        public async Task<string> GetClans()
        {
            return "test";
        }
    }
}
