using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleApp_RoleBasedAuth.Business.Abstract;
using SimpleApp_RoleBasedAuth.Business.Concrete;
using SimpleApp_RoleBasedAuth.Core.IoC;
using SimpleApp_RoleBasedAuth.DataAccess.Abstract;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework;
using SimpleApp_RoleBasedAuth.DataAccess.Concrete.EntityFramework.Context;
using SimpleApp_RoleBasedAuth.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp_RoleBasedAuth.WebUI
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
            services.AddMvc();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSession();
            services.AddDbContext<ApplicationDbContext>();
            
            services.AddIdentity<ApplicationUser, IdentityRole>(opt => {
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IAuthDal, AuthDal>();
            services.AddTransient<IAuthService, AuthManager>();
            services.AddTransient<IEmailSender, EMailSender>();
            services.AddScoped<IBoxService, BoxManager>();
            services.AddScoped<ICategoryDal, CategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IOrderDal, OrderDal>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IPaymentDal, PaymentDal>();
            services.AddScoped<IPaymentService, PaymentManager>();
            services.AddScoped<IPictureDal, PictureDal>();
            services.AddScoped<IPictureService, PictureManager>();
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddTransient<IUserDal, UserDal>();
            services.AddTransient<IUserService, UserManager>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("RequireUserRole", policy => policy.RequireRole("User"));
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
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{email?}");
            });
        }
    }
}
