using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a matchup.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entrants for this matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the team who won this matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round that this matchup is in.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}