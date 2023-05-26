using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice_Wise.Models;

namespace Spice_Wise.Controllers.Api.Ingredients
{
    [ApiController]
    [Route("api/ingredients")]
    public class IngredientsController : Controller
    {
        private readonly DataContext _context;

        public IngredientsController(DataContext context)
            => _context = context;

        [HttpPost]
        public async Task<ActionResult> Post(IngredientDto dto)
        {
            var model = new Ingredient();

            model.Id = dto.Id;
            model.Name = dto.Name;
            model.Unit = dto.Unit;
            model.IngredientCategoryId = dto.IngredientCategoryId;
            model.IngredientCategory = await _context
                .IngredientCategories
                .FirstOrDefaultAsync(x =>
                    x.Id == dto.IngredientCategoryId);

            _context.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }
}
