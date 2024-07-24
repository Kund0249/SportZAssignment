using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment.Models
{
    internal class Lineup
    {
       
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
    }

    internal class BowlingStats
    {
        public int PlayerId { get; set; }
        public int Wickets { get; set; }
    }
}
