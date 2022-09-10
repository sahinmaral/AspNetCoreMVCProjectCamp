using System.Collections.Generic;
using System.Globalization;
using AutoMapper;

using Business.Abstract;
using Business.Concrete;

using DataAccess.Abstract;
using DataAccess.Concrete;

using FluentValidation.AspNetCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;

using System.Reflection;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.Unicode;

using Entities.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;

namespace CoreDemo
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
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();

            services.AddSingleton<ICommentService, CommentManager>();
            services.AddSingleton<ICommentDal, EfCommentDal>();

            services.AddSingleton<IContactService, ContactManager>();
            services.AddSingleton<IContactDal, EfContactDal>();

            services.AddSingleton<IBlogService, BlogManager>();
            services.AddSingleton<IBlogDal, EfBlogDal>();

            services.AddSingleton<IAboutService, AboutManager>();
            services.AddSingleton<IAboutDal, EfAboutDal>();

            services.AddSingleton<INewsLetterService, NewsLetterManager>();
            services.AddSingleton<INewsLetterDal, EfNewsLetterDal>();

            services.AddSingleton<INotificationService, NotificationManager>();
            services.AddSingleton<INotificationDal, EfNotificationDal>();

            services.AddSingleton<INotificationService, NotificationManager>();
            services.AddSingleton<INotificationDal, EfNotificationDal>();

            //NotificationType and NotificationSymbol will be added

            services.AddSingleton<IMessageService, MessageManager>();
            services.AddSingleton<IMessageDal, EfMessageDal>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddFluentValidation(configuration =>
            {
                configuration.RegisterValidatorsFromAssemblyContaining<Startup>();
            });

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            CultureInfo[] supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("tr-TR")
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("tr-TR","tr-TR");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };
            });


            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});


            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            //{
            //    x.LoginPath = new PathString("/Login/Login");
            //    x.AccessDeniedPath = new PathString("/ErrorPage/ErrorPage/403");
            //    x.LogoutPath = new PathString("Blog/GetAll");
            //});

            services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
                options =>
                {
                    options.AccessDeniedPath = "/ErrorPage/ErrorPage/403";
                    options.LoginPath = "/Login/Login";
                    options.LogoutPath = "/Blog/GetAll";
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                {
                    policy.RequireRole("Admin");
                    policy.RequireClaim(ClaimTypes.Name, "Admin");
                });

                options.AddPolicy("Writer", policy =>
                {
                    policy.RequireRole("Writer");
                    policy.RequireClaim(ClaimTypes.Name, "Writer");
                });
            });

            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/ErrorPage/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Category}/{action=GetCategories}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=GetAll}/{id?}");
            });

            
        }
    }
}