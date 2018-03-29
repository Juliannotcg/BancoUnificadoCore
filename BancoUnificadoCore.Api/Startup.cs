﻿using BancoUnificadoCore.Domain.Handlers;
using BancoUnificadoCore.Domain.Interfaces;
using BancoUnificadoCore.Infrastructure.Context;
using BancoUnificadoCore.Infrastructure.Repository.Dapper;
using BancoUnificadoCore.Infrastructure.Repository.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Swashbuckle.AspNetCore.Swagger;
using System.IO.Compression;

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
            services.Configure<GzipCompressionProviderOptions>(
                options => options.Level = CompressionLevel.Optimal);

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
            });

            services.AddMvc().AddJsonOptions(opcoes =>
            {
                opcoes.SerializerSettings.NullValueHandling =
                    Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.AddScoped<ContextEntity, ContextEntity>();
            services.AddScoped<ContextDapper, ContextDapper>();
            services.AddScoped<TituloRepositoryDapper, TituloRepositoryDapper>();
            services.AddScoped<CargaDiariaRepositoryDapper, CargaDiariaRepositoryDapper>();
            services.AddScoped<ApresentanteRepositoryDapper, ApresentanteRepositoryDapper>();
            services.AddScoped<DevedorRepositoryDapper, DevedorRepositoryDapper>();
            services.AddScoped<CredorRepositoryDapper, CredorRepositoryDapper>();

            services.AddTransient<CargaDiariaHandler, CargaDiariaHandler>();
            services.AddTransient<ApresentanteHandler, ApresentanteHandler>();
            services.AddTransient<DevedorHandler, DevedorHandler>();

            services.AddTransient<IApresentanteRepositoryEntity, ApresentanteRepositoryEntity>();
            services.AddTransient<IApresentanteRepositoryDapper, ApresentanteRepositoryDapper>();

            services.AddTransient<IDevedorRepositoryDapper, DevedorRepositoryDapper>();
            services.AddTransient<IDevedorRepositoryEntity, DevedorRepositoryEntity>();

            services.AddTransient<ICargaDiariaRepositoryEntity, CargaDiariaRepositoryEntity>();
            services.AddTransient<ICargaDiariaRepositoryDapper, CargaDiariaRepositoryDapper>();

            services.AddTransient<ICredorRepositoryDapper, CredorRepositoryDapper>();

            services.AddTransient<ITituloRepositoryDapper, TituloRepositoryDapper>();

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
        }
    }
}
