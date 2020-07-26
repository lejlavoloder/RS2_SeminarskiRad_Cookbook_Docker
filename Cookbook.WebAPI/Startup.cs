using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Cookbook.WebAPI.Filters;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Cookbook.WebAPI
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

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Sastojak, SastojakSearchRequest,SastojakInsertRequest, SastojakInsertRequest>, SastojakService>();
            services.AddScoped<ICRUDService<Model.Kategorija,KategorijaSearchRequest,KategorijaInsertRequest,KategorijaInsertRequest>,KategorijaService>();
            services.AddScoped<ICRUDService<Model.MjernaJedinica, MjernaJedinicaSearchRequest, MjernaJedinicaInsertRequest, MjernaJedinicaInsertRequest>, MjernaJedinicaService>();

            var connection = @"data source =.; initial catalog = Cookbook; integrated security = True;";
            services.AddDbContext<CookbookContext>(options => options.UseSqlServer(connection));
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });
        }
    }
}
