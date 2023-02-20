using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using TheWanderingMentat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;

namespace TheWanderingMentat
{
    public class Startup
    {
        private readonly ILogger<Startup> _logger;

        public Startup(IConfiguration configuration, ILogger<Startup> logger) {
            _logger = logger;
        }

        public void Configure(IApplicationBuilder app) {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            _logger.LogInformation("Configuring app");

            var supporterLangs = new[] { "en", "pl" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supporterLangs[0])
                .AddSupportedCultures(supporterLangs)
                .AddSupportedUICultures(supporterLangs);
            app.UseRequestLocalization(localizationOptions);
        }
        public void ConfigureServices(IServiceCollection services) {
            //services.AddSingleton<AppConfig>();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddControllersWithViews();
            //services.AddLocalization(options => options.ResourcesPath = "Controllers");
            //Resources

        }
    }
}
