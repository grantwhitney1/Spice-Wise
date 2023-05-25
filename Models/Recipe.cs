namespace Spice_Wise.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
    public RecipeCategory? Category { get; set; }
    public int RecipeCategoryId { get; set; }
    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();
}
