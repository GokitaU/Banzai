namespace Banzai.Api
{
    using Microsoft.AspNetCore.Hosting;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("ReSharper", "TooManyChainedReferences")]
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
