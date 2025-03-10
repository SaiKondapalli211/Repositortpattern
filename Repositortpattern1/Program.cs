using Microsoft.EntityFrameworkCore;
using Repositortpattern1.Data;
using Repositortpattern1.Repositories.Implementations;
using Repositortpattern1.Repositories.Interfaces;
using Repositortpattern1.Singleton;

namespace Repositortpattern1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            var connectionString = builder.Configuration.GetConnectionString("default");
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));

            // Register PremiumCalculatorService as Singleton
            builder.Services.AddSingleton<IPremiumCalculatorService, PremiumCalculatorService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IPatient, PatientRepository>();

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