namespace Spice_Wise.Models;

public class Recipe : RecipeDto
{
    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();
}

public class RecipeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
    public virtual ICollection<RecipeCategory> Categories { get; set; } = new List<RecipeCategory>();
}