using Microsoft.EntityFrameworkCore;
using UniversiteAppBackend.DataAccess;
using UniversiteAppBackend.Controllers;
namespace UniversiteAppBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.. Usings to work wth EntityFramework
            
            var builder = WebApplication.CreateBuilder(args);

            //TODO: Connection with SQL Server
            const string CONNECTIONNAME = "DefaultConnection";
            var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

            //3. Add Context

            builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.Run();
        }
    }
}