namespace Spice_Wise.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Unit { get; set; } = String.Empty;
    public IngredientCategory? IngredientCategory { get; set; }
    public int IngredientCategoryId { get; set; }
    public virtual ICollection<StepIngredient> StepsIngredients { get; set; } = new List<StepIngredient>();
}
