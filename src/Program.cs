using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HelloWorld
{
    public class WebSite
    {

        public static void Main(string[] args){
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://0.0.0.0:5000")
                .Configure(app => app.Run(async context => {
                    await context.Response.WriteAsync("Hello World!");
                }))
                .Build();

            host.Run();
        }
    }
}
