namespace Banzai.Api.Common
{
    using System;
    using RestSharp;
    using Exceptions;
    using System.IO;
    using Newtonsoft.Json;
    using System.Threading.Tasks;

    public class Requestah
    {
        internal string ApiKey => LoadApiKey();

        public async Task<T> ExecuteAsync<T>(IRestRequest request) where T : class, new()
        {
            request.AddHeader("X-Auth-Token", ApiKey);

            var client = new RestClient
            {
                BaseUrl = new Uri(Constants.Resource.BASE_URL)
            };

            var tcs = new TaskCompletionSource<T>();
            client.ExecuteAsync<T>(request, restResponse =>
            {
                if (restResponse.ErrorException != null)
                    throw new RestException("Error retrieving response.", restResponse.ErrorException);

                tcs.SetResult(restResponse.Data);
            });

            return await tcs.Task;
        }

        private static string LoadApiKey()
        {
            var keyFile = JsonConvert.DeserializeObject<ApiKey>(File.ReadAllText("ApiKey.Json"));

            return keyFile.Key;
        }
    }
}