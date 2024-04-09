using System.ComponentModel.DataAnnotations;

namespace WeatherAppAPI.Entities
{
    public class Match
    {
        [Key]
        public int MatchID { get; set; }
        public int? HomeTeamID { get; set; }
        public int? AwayTeamID { get; set; }
        public DateTime? MatchDate { get; set; }
    }
}
