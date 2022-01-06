using GoWMS.Server.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using BlazorTable;
using Toolbelt.Blazor.Extensions.DependencyInjection;

// ******
// BLAZOR COOKIE Auth Code (begin)
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using AKSoftware.Localization.MultiLanguages;
using Microsoft.Extensions.Localization;
using System.Reflection;
using Microsoft.AspNetCore.Localization;
// BLAZOR COOKIE Auth Code (end)
// ******

using System.Globalization;



namespace GoWMS.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // Add Controllers for WebAPI
            services.AddControllers();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMudServices();
            services.AddResponseCaching();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMudServices();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<CustomerService>();
            services.AddSingleton<ErpApiService>();
            services.AddSingleton<StoreinService>();
            services.AddSingleton<WhService>();
            services.AddSingleton<ErpService>();
            services.AddSingleton<InvService>();
            services.AddSingleton<InboundService>();
            services.AddSingleton<MasService>();
            services.AddSingleton<WgcService>();
            services.AddSingleton<StoreoutService>();
            services.AddSingleton<DashService>();
            services.AddScoped<BlazorAppContext>();


            services.AddBlazorTable(); // Install-Package BlazorTable -Version 1.17.0 https://www.nuget.org/packages/BlazorTable



            // Add Authentication
            // https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.Cookie.Name = "gowmsauth";
                        options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                        options.EventsType = typeof(Controllers.CookieAuthenticationEvents);

                    });
            services.AddScoped<Controllers.CookieAuthenticationEvents>();




            //services.AddLocalization(opt => opt.ResourcesPath = "Resources");


            //services.AddLocalization(options => options.ResourcesPath = "Resources");
            //var supportedCultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("th") };
            //services.Configure<RequestLocalizationOptions>(options =>
            //{
            //  options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("th");
            //options.SupportedUICultures = supportedCultures;
            //});




        }

        private RequestLocalizationOptions GetlocalizationOptions()
        {
            var cultures = Configuration.GetSection("Cultures")
                .GetChildren().ToDictionary(x => x.Key, x => x.Value);
            var supportedCultures = cultures.Keys.ToArray();
            var localizationOptions = new RequestLocalizationOptions()
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            return localizationOptions;

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

            //app.UseRequestLocalization();
            //var localizations = new RequestLocalizationOptions()
            //    .SetDefaultCulture("en-US")
            //    .AddSupportedCultures("en-US", "th-TH")
            //    .AddSupportedUICultures("en-US", "th-TH");

            //app.UseRequestLocalization(localizations);

            app.UseResponseCaching();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRequestLocalization(GetlocalizationOptions());

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

        }
    }
}
