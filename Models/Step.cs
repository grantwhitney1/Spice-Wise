namespace Spice_Wise.Models;

public class Step
{
    public int Id { get; set; }
    public string Instruction { get; set; } = String.Empty;
    public Recipe? Recipe { get; set; }
    public int RecipeId { get; set; }
    
    public virtual ICollection<StepIngredient> StepsIngredients { get; set; } = new List<StepIngredient>();
}
