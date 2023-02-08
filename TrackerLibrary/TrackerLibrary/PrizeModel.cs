namespace TrackerLibrary
{
    /// <summary>
    /// Defines a prize for a competition.
    /// </summary>
    public  class PrizeModel
    {
        /// <summary>
        /// Represents the place number required to win this prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the prize to be won.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the financial value of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the pot (from entry fees) is awarded for this prize.
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}