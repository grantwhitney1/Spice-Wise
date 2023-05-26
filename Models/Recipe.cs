namespace Spice_Wise.Models;

public class Recipe : RecipeDto
{
    public RecipeCategory? Category { get; set; }
    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();
}

public class RecipeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
    public int RecipeCategoryId { get; set; }
}