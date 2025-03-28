using e_commerce.core.Interfaces;
using e_commerce.Service.Interfaces;
using e_commerce.Service.Services;
using e_commerce.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using e_commerce.Models;
using Infrasitructure.Repository;

namespace e_commerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region new in Program
            //builder.Services.AddScoped<ISiteUserRepository, SiteUserRepository>();
            builder.Services.AddScoped<IBaseRepository<Site_User>, BaseRepository<Site_User>> ();

            builder.Services.AddScoped<ISiteUserService, SiteUserService>();
            builder.Services.AddDbContext<Entity>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=DESKTOP-MV2T7M8\\SQLEXPRESS;Database=DEPIDataBase;Trusted_Connection=True;TrustServerCertificate=True")));

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
