using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace SchoolAPIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Configuration.AddJsonFile("ocelot.json");
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddOcelot();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseOcelot().Wait();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<StartupBase>();

        //    }).ConfigureAppConfiguration((HostingContext, config) =>
        //    {
        //        config.SetBasePath(HostingContext.HostingEnvironment.ContentRootPath)
        //        .AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
        //    });
    }
}