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
            var prod = await _context.Products.Where(c => c.Barcode == barcode)
                .Include(c => c.Ingredients).FirstOrDefaultAsync();
            if(prod == null)
                return NotFound();
            return prod;
        }

        
        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(await _context.Products.ToListAsync());
        }
        //[HttpPost]
        //public async Task<ActionResult<List<Product>>> AddPIngredient(Ingredient ingredient)
        //{
        //    _context.Ingredients.Add(ingredient);
        //    await _context.SaveChangesAsync();
        //    return Ok(await _context.Ingredients.ToListAsync());
        //}
        //[HttpGet]
        //[Route("Ingredient")]
        //public async Task<ActionResult<Product>> AddIngrediet(IngrProd request)
        //{
        //    var prod = await _context.Products
        //        .Where(c => c.Barcode == request.prodId)
        //        .Include(c => c.Ingredients)
        //        .FirstOrDefaultAsync();

        //    if(prod == null)
        //    {
        //        return NotFound();
        //    }

        //    var ingrediet = await _context.Ingredients.FindAsync(request.ingredietnId);
        //    if (ingrediet == null)
        //    {
        //        return NotFound();
        //    }

        //    return prod;
        //}
    }
}
