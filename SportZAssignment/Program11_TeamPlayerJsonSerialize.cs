using Newtonsoft.Json;
using SportZAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    internal class Program11_TeamPlayerJsonSerialize
    {
        static void Main(string[] args)
        {
            Team team = new Team()
            {
                FullName = "Sunrisers Hyderabad",
                ShortName = "SRH",
                players = new Dictionary<string, PlayerDetails>()
                {
                    { "5380",new PlayerDetails(){Position="1", FullName="David Warner",IsCaptain =true} },
                    { "3722",new PlayerDetails(){Position="2", FullName="Shikhar Dhawan",IsCaptain =false} }
                }
            };

            string JsonString = JsonConvert.SerializeObject(team, Formatting.Indented);
            Console.WriteLine(JsonString);
        }
    }
}
