using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment.Models
{
    internal class Player
    {
        [JsonProperty("PlayerName")]
        public string Name { get; set; }

        public bool IsRetired { get; set; }
    }
}
