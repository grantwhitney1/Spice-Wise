using Spice_Wise.Models.Static;

namespace Spice_Wise.Models;

public class Ingredient : IngredientGetDto
{
    public virtual ICollection<StepIngredient> StepsIngredients { get; set; } = new List<StepIngredient>();
}

public class IngredientGetDto : IngredientPostDto
{
    public int Id { get; set; }
}

public class IngredientPostDto
{
    public string Name { get; set; } = String.Empty;
    public string Unit { get; set; } = String.Empty;
    public string Category { get; set; } = String.Empty;
}