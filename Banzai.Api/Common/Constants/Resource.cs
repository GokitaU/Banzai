namespace Banzai.Api.Common.Constants
{
    public static class Resource
    {
        public const string BASE_URL = "http://football-data.org";

        public const string COMPETITION = "/v1/competitions/";
        public const string COMPETITION_TEAM = "/v1/competitions/{id}/teams";
        public const string COMPETITION_FIXTURE = "/v1/competitions/{id}/fixtures";
        public const string TABLE = "/v1/competitions/{id}/leagueTable";

        public const string FIXTURE = "/v1/fixtures/";
        public const string TEAM_FIXTURE = "/v1/teams/{id}/fixtures/";
        public const string TEAM = "/v1/teams/{id}";
        public const string PLAYER = "/v1/teams/{id}/players";
    }
}