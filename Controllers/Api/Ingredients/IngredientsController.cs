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

            if (dto.Name.IsNullOrEmpty() || dto.Unit.IsNullOrEmpty() || dto.IngredientCategory.IsNullOrEmpty())
                return BadRequest("This field cannot be empty.");

            if (dto.Name.Length > 24)
                return BadRequest("This field cannot exceed 24 characters.");

            if (dto.Name.Length < 3)
                return BadRequest("This field cannot be less than 3 characters.");

            //Object mapping
            
            model.Name = dto.Name;
            model.Unit = dto.Unit;
            model.IngredientCategory = dto.IngredientCategory;

            //Save to DB

            _context.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var models = await _context
                .Ingredients
                .ToListAsync();

            return Ok(models);
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult> Get(int Id)
        {
            var model = await _context
                .Ingredients
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (model == null)
                return NotFound("Could not find an ingredient with that Id in the database.");

            return Ok(model);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult> Put(int Id, IngredientPostDto dto)
        {
            var model = await _context
                .Ingredients
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (model == null)
                return NotFound("Could not find an ingredient with that Id in the database.");

            //Validation

            if (dto == null)
                return BadRequest("Cannot post a null entity.");

            if (dto.Name.IsNullOrEmpty() || dto.Unit.IsNullOrEmpty() || dto.IngredientCategory.IsNullOrEmpty())
                return BadRequest("This field cannot be empty.");

            if (dto.Name.Length > 24)
                return BadRequest("This field cannot exceed 24 characters.");

            if (dto.Name.Length < 3)
                return BadRequest("This field cannot be less than 3 characters.");

            //Object mapping

            model.Name = dto.Name;
            model.Unit = dto.Unit;
            model.IngredientCategory = dto.IngredientCategory;

            //Save to DB

            _context.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var model = await _context
                .Ingredients
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (model == null)
                return NotFound("Could not find an ingredient with that Id in the database.");

            _context.Remove(model);

            return Ok();
        }
    }
}
