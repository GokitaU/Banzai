namespace Banzai.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Common;
    using Models;
    using RestSharp;

    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = 
                await new Requestah().ExecuteAsync<Team>(BuildRequest(id));

            return Ok(response);
        }
        private IRestRequest BuildRequest(string id) =>
           new RestRequest($"{Common.Constants.Resource.TEAM}", Method.GET)
              .AddUrlSegment("id", id);
    }
}
