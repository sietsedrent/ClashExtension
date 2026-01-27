using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

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

        [HttpGet("/clans/{clanTag}/members")]
        public async Task<string> GetClanMembers(string clanTag)
        {
            //Nog base address zetten voor url 

            var url = "https://api.clashofclans.com/v1/clans/%23" + clanTag + "/members";
            

            //Nieuw object aanmaken bv. Player en Items
            return await _httpClient.GetStringAsync(url);

        }
    }
}
