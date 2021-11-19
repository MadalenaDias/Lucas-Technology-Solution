using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Startup.cs
using Microsoft.Identity.Web;
=======
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Startup.cs
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Startup.cs
namespace LTS.Services.Crm.API
=======
namespace LucasTechnologyServices.WebAPI.Core
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Startup.cs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Startup.cs
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
=======
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Startup.cs

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Startup.cs
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LTS.Services.Crm.API", Version = "v1" });
=======
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LucasTechnologyServices.WebAPI.Core", Version = "v1" });
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Startup.cs
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
<<<<<<< HEAD:LTS.Solution/Adapters/Driving/Crm/LTS.Services.Crm.API/Startup.cs
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LTS.Services.Crm.API v1"));
=======
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LucasTechnologyServices.WebAPI.Core v1"));
>>>>>>> origin/dev:source/WebAPIs/LucasTechnologyServices.WebAPI.Core/Startup.cs
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
