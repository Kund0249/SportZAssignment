using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment.Models
{
    internal class PlayerScore
    {
        [JsonProperty("Batsman")]
        public string Name { get; set; }
        public int RunsScored { get; set; }
        public float StrikeRate { get; set; }

        public double BattingMomentum => RunsScored * StrikeRate;

        public override string ToString()
        {
            return string.Format($"Batsman : {Name}, RunsScored : {RunsScored}, StrikeRate : {StrikeRate}");
        }
    }
}
