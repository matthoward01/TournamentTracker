using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> matchupEntries { get; set; } = new();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
