namespace Banzai.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common;
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using RestSharp;
    using System.Linq;

    [Route("api/[controller]")]
    public class CompetitionsController : Controller
    {
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response =
                await new Requestah().ExecuteAsync<List<Competition>>(BuildRequest(id));

            return Ok(response.Single(x => x.League.Equals("PL")));
        }
        private IRestRequest BuildRequest(string id) =>
           new RestRequest($"{Common.Constants.Resource.COMPETITION}", Method.GET)
              .AddUrlSegment("id", id);
    }
}
