using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//This API done by Jachob Clark

namespace WeatherAppAPI.Entities
{
    public class NewPlayer
    {
        [Key]
        public int PID { get; set; }
        public string PName { get; set; }
        public string PPosition { get; set; }
        public int? PNumber { get; set; }
        public int? TeamID { get; set; }
    }
}
