using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Outdoor_paradise_webapp.Models;

[assembly: HostingStartup(typeof(Outdoor_paradise_webapp.Areas.Identity.IdentityHostingStartup))]
namespace Outdoor_paradise_webapp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityContextConnectionAzure")));

                //services.AddDefaultIdentity<IdentityUser>()
                    //.AddEntityFrameworkStores<IdentityContext>();
            });
        }
    }
}