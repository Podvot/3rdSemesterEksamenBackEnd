using Business.Service.IngredientService;
using Business.Service.MenuItemService;
using Business.Service.RecipeService;
using Data;
using Data.Repository.IngredientRepository;
using Data.Repository.MenuItemRepository;
using Data.Repository.RecipeRepository;
using Microsoft.EntityFrameworkCore;

namespace Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<KaffeshopContext>(opts =>
            opts.UseSqlServer("Server=EASV-DB4\\MSSQLSERVER,1433;Database=KaffekunstDB;User Id=CSe2022t_t_9;Password=CSe2022tT9#;TrustServerCertificate=True;"));
        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddLogging();
        builder.Services.AddCors();
        
        // Services
        builder.Services.AddScoped<IIngredientService, IngredientService>();
        builder.Services.AddScoped<IRecipeService, RecipeService>();
        builder.Services.AddScoped<IMenuItemService, MenuItemService>();
        builder.Services.AddScoped<IMenuItemRecipeService, MenuItemRecipeService>();
        builder.Services.AddScoped<IRecipeIngredientsService, RecipeIngredientsService>();

        //Repositories
        builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
        builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
        builder.Services.AddScoped<IMenuItemRepository, MenuItemRepository>();
        builder.Services.AddScoped<IRecipeIngredientRepository, RecipeIngredientRepository>();
        builder.Services.AddScoped<IMenuItemRecipeRepository, MenuItemRecipeRepository>();
        builder.Services.AddControllers();
        
        // Adding and using Swagger/OpenAPI to run the program
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
        app.UseRouting();
        //app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.MapControllers();

        app.Run();
        
    }
}