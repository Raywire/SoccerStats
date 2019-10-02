using Newtonsoft.Json;

namespace SoccerStats
{
    public class RootObject
    {
        public Player[] Player { get; set; }
    }

    public class Player
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("points_per_game")]
        public double PointsPerGame { get; set; }

        [JsonProperty("second_name")]
        public string SecondName { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }
    }
}
