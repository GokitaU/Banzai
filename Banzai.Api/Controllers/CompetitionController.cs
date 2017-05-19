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
            var requestah = new Requestah();
            
            var response = 
                await requestah.ExecuteAsync<List<Competition>>(BuildRequest(id));
            
            return Ok(response.Single(x => x.League.Equals("PL")));
        }

        private static IRestRequest BuildRequest(string id)
        {
            var apiResource = $"{Common.Constants.Resource.COMPETITION}";

            var request = 
                new RestRequest(apiResource, Method.GET).AddUrlSegment("id", id);

            return request;
        }
    }
}