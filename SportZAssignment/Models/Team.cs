using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment.Models
{
    internal class Team
    {
        [JsonProperty("Name_Full")]
        public string FullName { get; set; }

        [JsonProperty("Name_Short")]
        public string ShortName { get; set; }

        public Dictionary<string, PlayerDetails> players { get; set; }
    }

    internal class PlayerDetails
    {
        public string Position { get; set; }

        [JsonProperty("Name_Full")]
        public string FullName { get; set; }

        public bool IsCaptain { get; set; }
    }
}
