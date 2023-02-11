using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesLodge.Core.Entities
{
    public class CharacterDetails
    {
        /*[JsonProperty("age")]
        public Age Age { get; set; }

        [JsonProperty("alignment")]
        public Age Alignment { get; set; }

        [JsonProperty("alliance")]
        public string Alliance { get; set; }

        [JsonProperty("biography")]
        public Biography Biography { get; set; }

        [JsonProperty("deity")]
        public Deity Deity { get; set; }

        [JsonProperty("ethnicity")]
        public Age Ethnicity { get; set; }

        [JsonProperty("gender")]
        public Age Gender { get; set; }

        [JsonProperty("height")]
        public Age Height { get; set; }*/

        [JsonProperty("keyability")]
        public string KeyAbility { get; set; }

        /*[JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("nationality")]
        public Age Nationality { get; set; }

        [JsonProperty("weight")]
        public Age Weight { get; set; }

        [JsonProperty("xp")]
        public Xp Xp { get; set; }*/
    }
}
