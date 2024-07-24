using Newtonsoft.Json;
using SportZAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SportZAssignment
{
    internal class Program10_InverseFlag
    {
        static void Main(string[] args)
        {
            string Players = @"[
                                {""PlayerName"": ""Virat Kholi"", ""IsRetired"" : 1},
                                {""PlayerName"": ""M.S. Dhoni"", ""IsRetired"" : 1},
                                {""PlayerName"": ""Hardik Pandya"", ""IsRetired"" : 1},
                                {""PlayerName"": ""Rohit Sharma"", ""IsRetired"" : 1},
                                {""PlayerName"": ""Sachin Tendulkar"", ""IsRetired"" : 0},
                                {""PlayerName"": ""Rahul Dravid"", ""IsRetired"" : 0},
                                {""PlayerName"": ""Sourav Ganguly"", ""IsRetired"" : 0},
                                {""PlayerName"": ""VVS Laxman"", ""IsRetired"" : 0}
                                ]
                                ";

            try
            {
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(Players);
                if (players != null)
                {
                    if (players.Count > 0)
                    {
                        Console.WriteLine("-------------Before Inverse---------------------");
                        players.ForEach(x => Console.WriteLine($"Player Name : {x.Name}, IsRetired : {x.IsRetired}"));


                        Console.WriteLine("-------------After Inverse---------------------");

                        //Approach 1
                        players.ForEach(x => x.IsRetired = !x.IsRetired);
                        players.ForEach(x => Console.WriteLine($"Player Name : {x.Name}, IsRetired : {x.IsRetired}"));

                        //Approach 2
                        //List<Player> plyerlist = players.ConvertAll(x =>
                        //{
                        //    x.IsRetired = !x.IsRetired;
                        //    return x;
                        //});

                        //plyerlist.ForEach(x => Console.WriteLine($"Player Name : {x.Name}, IsRetired : {x.IsRetired}"));
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
