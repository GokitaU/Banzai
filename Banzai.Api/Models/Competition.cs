namespace Banzai.Api.Models
{
    using RestSharp.Deserializers;

    public class Competition
    {
        [DeserializeAs(Name = "_links")]
        public CompetitionLinks Links { get; set; }

        public int Id { get; set; }
        public string Caption { get; set; }
        public string League { get; set; }
        public string Year { get; set; }
        public int CurrentMatchday { get; set; }
        public int NumberOfMatchdays { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfGames { get; set; }
        public string LastUpdated { get; set; }
    }

    public class CompetitionLinks
    {
        public Self Self { get; set; }
        public Teams Teams { get; set; }
        public Fixtures Fixtures { get; set; }
        public LeagueTable LeagueTable { get; set; }
    }
}