namespace Spice_Wise.Models;

public class StepIngredient : StepIngredientDto
{
    public Step? Step { get; set; }
    public Ingredient? Ingredient { get; set; }
}

public class StepIngredientDto
{
    public int Id { get; set; }
    public int StepId { get; set; }
    public int IngredientId { get; set; }
}