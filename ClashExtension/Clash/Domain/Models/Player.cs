using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Clash.Domain.Models
{
    public class Player
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel { get; set; }
    }
    public class Items 
    {

    }
}
