using SportZAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace SportZAssignment
{
    internal class Program9_PlayerBattingMomentum
    {
        static PlayerScore GetBatsmaBestBattingMomentum(List<PlayerScore> players)
        {
            PlayerScore player = null;
            double highestMomentum = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].BattingMomentum > highestMomentum)
                {
                    highestMomentum = players[i].BattingMomentum;
                    player = players[i];
                }
            }
            return player;
        }
        static void Main(string[] args)
        {
            string Player = @"[{""Batsman"": ""Virat Kholi"", ""RunsScored"": 50, ""StrikeRate"": 78.30},
                               {""Batsman"": ""M.S.Dhoni"", ""RunsScored"": 61, ""StrikeRate"": 58.90},
                               {""Batsman"": ""Rohit Sharma"", ""RunsScored"": 13, ""StrikeRate"": 124.0}
                               ]
                              ";
            try
            {
                List<PlayerScore> players = JsonConvert.DeserializeObject<List<PlayerScore>>(Player);

                if (players != null)
                {
                    if (players.Count > 0)
                    {
                        PlayerScore playerWithBestBattingMomentum = GetBatsmaBestBattingMomentum(players);

                        if (playerWithBestBattingMomentum != null)
                            Console.WriteLine(playerWithBestBattingMomentum.ToString());

                        //-----------By using LINQ--------------------------

                        Console.WriteLine("------Using Linq-----------------");
                        PlayerScore _playerWithBestBattingMomentum = players.OrderByDescending(p => p.BattingMomentum).FirstOrDefault();
                        if (_playerWithBestBattingMomentum != null)
                        {
                            Console.WriteLine(_playerWithBestBattingMomentum.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
