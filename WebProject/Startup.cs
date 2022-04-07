namespace WebProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            services.AddMvcCore(o => o.EnableEndpointRouting = false);
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
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "WeatherForecast", action = "Page" }
                 )
             );

        }
    }
}
