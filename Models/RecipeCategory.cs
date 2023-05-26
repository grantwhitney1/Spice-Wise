namespace Spice_Wise.Models;

public class RecipeCategory : RecipeCategoryDto
{
    public virtual ICollection<Recipe> Recipes { get; set;} = new List<Recipe>();
}

public class RecipeCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
}
