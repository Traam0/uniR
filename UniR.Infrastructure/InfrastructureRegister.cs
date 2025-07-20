using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UniR.Contracts.Interfaces;
using UniR.Infrastructure.Data;

namespace UniR.Infrastructure;

public static class InfrastructureRegister
{
    public static void RegisterInfrastructure(this IHostApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            var connectionString = builder.Configuration.GetConnectionString("MySQL");

            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

            if (builder.Environment.IsDevelopment())
            {
                options.EnableSensitiveDataLogging();
            }
        });

        builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
    }
}