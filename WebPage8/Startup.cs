using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.Services;

namespace WebPage8
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("ComputerWebShop")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddAuthentication()
                .AddGoogle(Options =>
                {
                    Options.ClientId = "639378123396-ujb8jm9g3qdj3tbhhg9hrkf3qnscc2e8.apps.googleusercontent.com";
                    Options.ClientSecret = "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";
                })
                //.AddTwitter(Options =>
                //{
                //    Options.ClientId = "";
                //    Options.ClientSecret = "";
                //    Options.ConsumerKey = Configuration["Authentication:Twitter:ConsumerKey"];
                //    Options.ConsumerSecret = Configuration["Authentication:Twitter:ConsumerSecret"];
                //})
                .AddFacebook(Options =>
                {
                    Options.ClientId = "4314705901960193";
                    Options.ClientSecret = "f6039b3b9a8c46d4c4d7d642e2e88564";
                });

            services.AddScoped<IComputerRepo, ComputerRepo>();
            services.AddScoped<IComputerService, ComputerService>();

            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<ICategoryService, CategoryService>();

            //When user come to the site, it will create shopping cart using GetCart()
            services.AddScoped<ShoppingCart>(s => ShoppingCart.GetCart(s));
            services.AddHttpContextAccessor();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            StripeConfiguration.ApiKey = "sk_test_51Jon20KkIU2Q37zYayDzpiksSc2o7kOMCREZQSzGvNFNm7eSMsmbhhrAtO5PLdKSreyvvMKqmGujcmhOvvRWuwEo00ZhBcwT1O";

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession(); //always call session before routing


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
