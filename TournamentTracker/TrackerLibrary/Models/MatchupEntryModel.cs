using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came from as the winner. 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
