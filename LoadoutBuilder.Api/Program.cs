
using AutoMapper;
using LoadoutBuilder.Data;
using LoadoutBuilder.Infrastructure;
using LoadoutBuilder.Infrastructure.Contracts;
using LoadoutBuilder.Mapping;
using LoadoutBuilder.Mapping.Contracts;
using LoadoutBuilder.Mapping.Mappings;
using LoadoutBuilder.Services;
using LoadoutBuilder.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LoadoutBuilder.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext"));

        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
        });
        var configExpression = new MapperConfigurationExpression();
        configExpression.AddProfile<LoadoutProfile>();
        var mapperConfig = new MapperConfiguration(configExpression, loggerFactory);
        var mapper = mapperConfig.CreateMapper();

        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped(typeof(ILoadoutService), typeof(LoadoutService));
        builder.Services.AddSingleton<IMapper>(mapper);
        builder.Services.AddScoped<ICustomMapper, AutoMapperAdapter>();
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
