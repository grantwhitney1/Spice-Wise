namespace Spice_Wise.Models;

public class Ingredient : IngredientDto
{
    public IngredientCategory? IngredientCategory { get; set; }
    public virtual ICollection<StepIngredient> StepsIngredients { get; set; } = new List<StepIngredient>();
}

public class IngredientDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Unit { get; set; } = String.Empty;
    public int IngredientCategoryId { get; set; }
}