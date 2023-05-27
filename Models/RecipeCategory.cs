namespace Spice_Wise.Models;

public class RecipeCategory : RecipeCategoryDto
{
    public int Id { get; set; }
}

public class RecipeCategoryDto
{
    public string Name { get; set; } = String.Empty;
}