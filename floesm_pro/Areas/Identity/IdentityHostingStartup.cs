using System;
using floesm_pro.Areas.Identity.Data;
using floesm_pro.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(floesm_pro.Areas.Identity.IdentityHostingStartup))]
namespace floesm_pro.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<floesmDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("floesmDBContextConnection")));

                services.AddDefaultIdentity<floesmUser>(options =>
                {
                    //set true to send confirmation email
                    options.SignIn.RequireConfirmedAccount = false;

                    //set true to password Upper and Lowercase validation
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                }
                

                )
                    .AddEntityFrameworkStores<floesmDBContext>();
            });
        }
    }
}