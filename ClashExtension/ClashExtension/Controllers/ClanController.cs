using Clash.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;
using Clash.Domain.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

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
            var response = await _httpClient.GetStringAsync(url);
            
            Player? response2 = JsonSerializer.Deserialize<Player>(response);
            if(response2 == null)
            {
                Console.WriteLine("leeg?");
            }

            //var name = response2.items.;

            // nee -> obj aanmaken
            List<Player> names = new List<Player>();
            List<Player> roles = new List<Player>();
            List<Player> tags =  new List<Player>();

            //foreach(var res in response2)
            //{
            //    names.Add(res.Name);
            //    roles.Add(res.Role);
             //   roles.Add(res.Tags);
            //}

            //Console.WriteLine(response2);
            
            return response;
            

            //Nieuw object aanmaken bv. Player en Items

        }
    }
}
