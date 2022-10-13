using System;
using DisasterAlleviationFoundation_prototype.Areas.Identity.Data;
using DisasterAlleviationFoundation_prototype.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DisasterAlleviationFoundation_prototype.Areas.Identity.IdentityHostingStartup))]
namespace DisasterAlleviationFoundation_prototype.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DisasterAlleviationFoundation_prototypeDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DisasterAlleviationFoundation_prototypeDBContextConnection")));

                services.AddDefaultIdentity<DisasterAlleviationFoundation_prototypeUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DisasterAlleviationFoundation_prototypeDBContext>();
            });
        }
    }
}