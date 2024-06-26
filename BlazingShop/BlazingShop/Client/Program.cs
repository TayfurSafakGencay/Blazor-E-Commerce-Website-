using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazingShop.Client.Services.CategoryService;
using BlazingShop.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingShop.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      builder.Services.AddScoped<IProductService, ProductService>();
      builder.Services.AddScoped<ICategoryService, CategoryService>();
      
      await builder.Build().RunAsync();
    }
  }
}