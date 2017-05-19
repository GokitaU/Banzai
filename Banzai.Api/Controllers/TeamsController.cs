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
            var requestah = new Requestah();

            var apiResource = $"{Common.Constants.Resource.TEAM}";
            
            var request = new RestRequest(apiResource, Method.GET);
    
            request.AddUrlSegment("id", id);

            var response = await requestah.ExecuteAsync<Team>(request);

            return Ok(response);
        }
    }
}
