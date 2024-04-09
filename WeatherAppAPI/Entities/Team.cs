using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//This API done by Jachob Clark

namespace WeatherAppAPI.Entities
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamLocation { get; set; }
    }
}
