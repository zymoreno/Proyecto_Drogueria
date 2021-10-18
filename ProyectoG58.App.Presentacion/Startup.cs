using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Presentacion
{
    public class Startup
    {

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
       
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                builder =>
                                {
                                    builder.WithOrigins("http://localhost:5001",
                                                        "https://localhost:5001")
                                                        .AllowAnyHeader()
                                                        .AllowAnyMethod();
                                });
            });

            services.AddControllers();
            services.AddRazorPages();
            services.AddScoped<IRepositorioClientes, RepositorioClientes>();
<<<<<<< HEAD
             services.AddScoped<IRepositorioProveedores, RepositorioProveedores>();
            services.AddSingleton<ProyectoG58.App.Persistencia.AppContext>();
            //escribir los servicios de los IRepositorios
=======
            services.AddSingleton<ProyectoG58.App.Persistencia.AppContext>();
            
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
