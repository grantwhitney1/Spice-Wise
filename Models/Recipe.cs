using Spice_Wise.Models.Static;

namespace Spice_Wise.Models;

public class Recipe : RecipeGetDto
{
    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();
}

public class RecipeGetDto : RecipePostDto
{
    public int Id { get; set; }
}

public class RecipePostDto
{
    public string Name { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
    public string Category { get; set; } = String.Empty;
}