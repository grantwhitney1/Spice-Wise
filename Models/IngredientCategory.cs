using System.Collections;

namespace Spice_Wise.Models;

public class IngredientCategory : IngredientCategoryDto
{
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}

public class IngredientCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
}
