using DBContexts.DBContexts;
using Microsoft.EntityFrameworkCore;
using WebProject.Domain.Repositories.Abstract;
using WebProject.Domain.Repositories.EF;

namespace WebProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            services.AddMvcCore(o => o.EnableEndpointRouting = false);
            //var connection = @"Server=(localdb)\MSSQLLocalDB;Database=WebProject;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<DataContext>();
            services.AddTransient<IWeatherDay, EFWeatherDay>();

            //services.AddSingleton<IMyPropertiesRepository, MyPropertiesRepository>();
            //string connection = @"Server=(localdb)\MSSQLLocalDB;Database=WebProject;Trusted_Connection=True;ConnectRetryCount=0";
            // services.AddDbContext<MyPropertiesContext>(options => options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc(c =>
                 c.MapRoute(
                     name: "default",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Root", action = "Page" }
                 )
             );
            app.Map("/home", Home);
            app.Map("/weatherforecast", WeatherForecast);
            app.Map("/weatherdayviews", WeatherDayViews);
        }

        private static void Home(IApplicationBuilder app)
        {
            app.UseMvc(c =>
                 c.MapRoute(
                     name: "home",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Home", action = "Page" }
                 )
             );
        }
        private static void WeatherForecast(IApplicationBuilder app)
        {
            app.UseMvc(c =>
                 c.MapRoute(
                     name: "weatherforecast",
                     //name: "weatherdayviews",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "WeatherForecast", action = "Page" }
                 )
             );
        }
        private static void WeatherDayViews(IApplicationBuilder app)
        {
            app.UseMvc(c =>
                 c.MapRoute(
                     name: "weatherdayviews",
                     //name: "weatherdayviews",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "WeatherDayViews", action = "Create" }
                 )
             );
        }
    }
}
