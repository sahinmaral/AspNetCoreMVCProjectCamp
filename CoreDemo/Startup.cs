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
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

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
            
            services.AddSingleton<IWriterService, WriterManager>();
            services.AddSingleton<IWriterDal, EfWriterDal>();
            
            services.AddSingleton<IAboutService, AboutManager>();
            services.AddSingleton<IAboutDal, EfAboutDal>();

            services.AddSingleton<INewsLetterService, NewsLetterManager>();
            services.AddSingleton<INewsLetterDal, EfNewsLetterDal>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddFluentValidation(configuration =>
            {
                configuration.RegisterValidatorsFromAssemblyContaining<Startup>();
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            {
                //x.LoginPath = "/ErrorPage/ErrorPage/401";
                x.LoginPath = "/Login/LoginWriter";
            });
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
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}