using Newtonsoft.Json;
using SportZAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    internal class Program12_LineupBowlingStats
    {
        static void Main(string[] args)
        {
            string _Lineups = @"
                                [
                                {""PlayerId"" : 21,""PlayerName"": ""Y. Chahal""},
                                {""PlayerId"" : 22,""PlayerName"": ""Bhuvneshwar Kumar""},
                                {""PlayerId"" : 23,""PlayerName"": ""Jasprit Bumrah""},
                                {""PlayerId"" : 24,""PlayerName"": ""Hardik Pandya""},
                                {""PlayerId"" : 25,""PlayerName"": ""Ravindra Jadeja""},
                                {""PlayerId"" : 26,""PlayerName"": ""Mohammed Shami""}
                                ]
                                ";

            string _bowlingStats = @"[
                                        {""PlayerId"" : 21, ""Wickets"": 2},
                                        {""PlayerId"" : 22, ""Wickets"": 1},
                                        {""PlayerId"" : 23, ""Wickets"": 3},
                                        {""PlayerId"" : 26, ""Wickets"": 1}
                                     ]";

            try
            {
                List<Lineup> lineups = JsonConvert.DeserializeObject<List<Lineup>>(_Lineups);
                List<BowlingStats> bowlingStats = JsonConvert.DeserializeObject<List<BowlingStats>>(_bowlingStats);

                if(lineups != null && bowlingStats != null)
                {
                    var results = (from lineup in lineups
                                   join bstats in bowlingStats
                                   on lineup.PlayerId equals bstats.PlayerId into LineupStates
                                   from bstats in LineupStates.DefaultIfEmpty()
                                   select new
                                   {
                                       PlayerId = lineup.PlayerId,
                                       PlayerName = lineup.PlayerName,
                                       Wicktes = bstats?.Wickets ?? 0
                                   }).ToList();

                    string Jsonstring = JsonConvert.SerializeObject(results, Formatting.Indented);
                    Console.WriteLine(Jsonstring);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
