using System.Collections;

namespace Spice_Wise.Models;

public class IngredientCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
