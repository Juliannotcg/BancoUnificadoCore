using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Dapper;
using BancoUnificadoCore.Infrastructure.Repository.EntityFramework;
using Elmah.Io.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace BancoUnificadoCore.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddResponseCompression();

            services.AddScoped<ContextEntity, ContextEntity>();
            services.AddScoped<ContextDapper, ContextDapper>();
            services.AddTransient<CargaDiariaHandler, CargaDiariaHandler>();
            services.AddTransient<IApresentanteRepository, ApresentanteRepositoryEntity>();
            services.AddTransient<IApresentanteRepositoryDapper, ApresentanteRepositoryDapper>();
            services.AddTransient<ICargaDiariaRepository, CargaDiariaRepositoryEntity>();
            services.AddTransient<ApresentanteHandler, ApresentanteHandler>();

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info { Title = "BancoUnificadoCore", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
            app.UseResponseCompression();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BancoUnificadoCore - V1");
            });

            //app.UseElmahIo("923f4c946cc1435cb0ec665d6e7370b7", new Guid("e42a9995-df89-4d91-a625-ecc57d124004"));
        }
    }
}
