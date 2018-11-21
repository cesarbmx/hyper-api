﻿using System.Reflection;
using System.Security.Principal;
using CoinMarketCap;
using CoinMarketCap.Core;
using CryptoWatcher.Domain.Repositories;
using CryptoWatcher.Domain.Services;
using CryptoWatcher.Persistence.Contexts;
using CryptoWatcher.Persistence.Repositories;
using CryptoWatcher.Shared.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoWatcher.Api.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddScoped<IPinnacleTokenService<CryptoWatcherPermission>, PinnacleTokenService<CryptoWatcherPermission>>();

            //Contexts (UOW)
            //services.AddDbContext<MainDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CryptoWatcher")));
            services.AddDbContext<MainDbContext>(options => options.UseInMemoryDatabase("CryptoWatcher"));

            // Services
            services.AddScoped<CacheService, CacheService>();
            services.AddScoped<CurrencyService, CurrencyService>();
            services.AddScoped<StatusService, StatusService>();
            services.AddScoped<ErrorMessagesService, ErrorMessagesService>();
            services.AddScoped<LogService, LogService>();
            services.AddScoped<HypeService, HypeService>();

            // Repositories
            services.AddScoped<ICacheRepository, CacheRepository>(); // TODO: (Cesar) app settings switch for audit
            services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<IHypeRepository, HypeRepository>();

            // Other
            services.AddScoped<HttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICoinMarketCapClient, CoinMarketCapClient>();
            services.AddScoped(factory => Assembly.GetExecutingAssembly());
            services.AddScoped<IPrincipal>( x => x.GetService<IHttpContextAccessor>().HttpContext.User);

            return services;
        }
    }
}
