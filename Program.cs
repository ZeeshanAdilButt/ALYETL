using ALYETL.ProdModels;
using ALYETL.StgModels;
using Microsoft.EntityFrameworkCore;

namespace ALYETL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<dbproddec27Context>(options =>
             options.UseSqlServer(builder.Configuration["PRODConn"]));

            builder.Services.AddDbContext<dbstgdec27Context>(options =>
      options.UseSqlServer(builder.Configuration["StgConn"]));


            var app = builder.Build();


            // Add services to the container.
         

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