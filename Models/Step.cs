namespace Spice_Wise.Models;

public class Step : StepDto
{
    public Recipe? Recipe { get; set; }
    public virtual ICollection<StepIngredient> StepsIngredients { get; set; } = new List<StepIngredient>();
}

public class StepDto
{
    public int Id { get; set; }
    public string Instruction { get; set; } = String.Empty;
    public int RecipeId { get; set; }
}