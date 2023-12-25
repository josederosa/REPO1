using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebConAPI.Client;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using System.Net;
using System.IO;


namespace WebConAPI.Client
{
   
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://intranet.bas.com.ar/bascsapiv02/") });
            builder.Services.AddSingleton<TokenAdmin>(); 

            await builder.Build().RunAsync();
        }        

    }
}