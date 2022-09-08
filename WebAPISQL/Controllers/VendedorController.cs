using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISQL.Models;
using WebAPISQL.Context;


namespace WebAPISQL.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class VendedorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public VendedorController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Vendedor>> GetAll()
        {
            var result = await _context.Vendedor
                .OrderBy(x => x.Ven_Empresa)
                .ToListAsync();

            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }


        [HttpGet("{codigo:int}")]
        public async Task<ActionResult<Vendedor>> GetByCode(int codigo)
        {
            var result = await _context.Vendedor
                .Where(x => x.Ven_Codigo == codigo)
                .OrderBy(x=>x.Ven_Codigo)
                .ToListAsync();

            if (!result.Any())  return NotFound();

            return Ok(result);
            

        }


        [HttpGet("{empresa}")]
        public async Task<ActionResult<Vendedor>> GetByCompany(string empresa)
        {
            var result = await _context.Vendedor
                .Where(x => x.Ven_Empresa == empresa)
                .OrderBy(x => x.Ven_Empresa)
                .ToListAsync();

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }


    }
}
