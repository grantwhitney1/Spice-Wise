namespace Spice_Wise.Models;

public class RecipeCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public virtual ICollection<Recipe> Recipes { get; set;} = new List<Recipe>();
}
