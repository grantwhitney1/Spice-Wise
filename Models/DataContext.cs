using Microsoft.EntityFrameworkCore;
using Spice_Wise.Models.Static;

namespace Spice_Wise.Models;

public class DataContext : DbContext
{
    private readonly IConfiguration _config;
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Step> Steps { get; set; }
    public DbSet<StepIngredient> StepsIngredients { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    public DataContext(IConfiguration config)
        => _config = config;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
}