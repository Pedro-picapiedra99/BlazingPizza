using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection; 
using BlazingPizza.Server.Models;

namespace BlazingPizza.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var Host = CreateHostBuilder(args).Build();
            var ScopeFactory =
                Host.Services.GetRequiredService<IServiceScopeFactory>();
            using (var Scope = ScopeFactory.CreateScope())
            {
                var Context = Scope.ServiceProvider
                    .GetRequiredService<PizzaStoreContext>();
                if (!Context.Specials.Any())
                {
                    SeedData.Initialize(Context);
                }
            }
            Host.Run();
    }
        builder.Services.AddScoped(sp => newHttpClient
            { BaseAddress = newUri(builder.HostEnvironment.BaseAddress) });
    }
