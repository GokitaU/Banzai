namespace Banzai.Api.Models
{
    using System.Diagnostics.CodeAnalysis;
    using RestSharp.Deserializers;

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Team
    {
        [DeserializeAs(Name = "_links")]
        public TeamLinks Links { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public object SquadMarketValue { get; set; }
        public string CrestUrl { get; set; }
    }

    public class TeamLinks
    {
        public Self Self { get; set; }
        public Fixtures Fixtures { get; set; }
        public Players Players { get; set; }
    }
}