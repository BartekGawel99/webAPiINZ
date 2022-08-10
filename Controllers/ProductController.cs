using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webAPiINZ.Data;
using webAPiINZ.Model;

namespace webAPiINZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly InżContext _context;

        public ProductController(InżContext context)
        {
            _context = context;
        }

        [HttpGet("{barcode}")]
        public async Task<ActionResult<Product>> Get(string barcode)
        {
            var prod = await _context.Products.Where(c => c.Barcode == barcode).FirstOrDefaultAsync();
            if (prod == null)
                return NotFound();

            var list = await _context.IngrProds.Where(id => id.prodId == barcode).ToListAsync();
            var listIng = await _context.Ingredients.ToListAsync();
            var result = listIng.Where(p => !list.All(p2 => p2.ingredietnId == p.IdIgredient)).ToList();

            if(result.Count != 0)
            {
               prod.Ingredients = result;
            }           

            return prod;
        }

        [HttpGet]
        [Route("/ListIngrediets")]
        public async Task<ActionResult<List<Ingredient>>> GetIngredients()
        {
            var ingList =  await _context.Ingredients.ToListAsync();
            return ingList;
        }

        [HttpPost]
        [Route("/AddIngrediet")]
        public async Task<ActionResult> AddIngredint([FromBody] Ingredient ingredient)
        {
            if (ingredient == null)
                return BadRequest();

            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
            return Ok();
        }       

        
        [HttpPost]
        [Route("/AddProduct")]
        public async Task<ActionResult<bool>> AddProduct([FromBody] Product product)
        {
            List<Ingredient> listIng = new List<Ingredient>();

            listIng = product.Ingredients;
            List<IngrProd> ingrProd = new List<IngrProd>();
            try
            {                
                IngrProd ingrProds = new IngrProd();
                
                    foreach (var ingredient in listIng)
                    {
                        ingrProd.Add(new IngrProd { prodId = product.Barcode, ingredietnId = ingredient.IdIgredient});

                    }

                product.Ingredients.Clear();
                _context.IngrProds.AddRange(ingrProd);
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
    }
}
