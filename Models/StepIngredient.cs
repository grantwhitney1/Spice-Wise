namespace Spice_Wise.Models;

public class StepIngredient
{
    public int Id { get; set; }
    public int StepId { get; set; }
    public Step? Step { get; set; }
    public int IngredientId { get; set; }
    public Ingredient? Ingredient { get; set; }
}
