using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        public async Task<ActionResult> Post(IngredientPostDto dto)
        {
            var model = new Ingredient();

            //Validation

            if(dto == null)
                return BadRequest("Cannot post a null entity.");

            if (dto.Name.IsNullOrEmpty() || dto.Unit.IsNullOrEmpty())
                return BadRequest("This field cannot be empty.");

            if (dto.Name.Length > 24)
                return BadRequest("This field cannot exceed 24 characters.");

            if (dto.Name.Length < 3)
                return BadRequest("This field cannot be less than 3 characters.");

            if (!await _context.IngredientCategories.AnyAsync(x => x.Id == dto.IngredientCategoryId))
                return NotFound("The given ingredient category cannot be found.");

            //Object mapping
            
            model.Name = dto.Name;
            model.Unit = dto.Unit;
            model.IngredientCategoryId = dto.IngredientCategoryId;
            model.IngredientCategory = await _context
                .IngredientCategories
                .FirstOrDefaultAsync(x =>
                    x.Id == dto.IngredientCategoryId);

            //Save to DB

            _context.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var models = await _context.Ingredients.ToListAsync();

            return Ok(models);
        }
    }
}
