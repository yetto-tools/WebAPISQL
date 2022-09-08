using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISQL.Context;
using WebAPISQL.Models;

namespace WebAPISQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MastcliController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MastcliController(ApplicationDbContext context)
        {
            _context = context;
            _context.Database.SetCommandTimeout(1500);
        }

        /*
         * NOT WORKING TOO LOT REGISTER AND CLIENT FREEZING 
         */

        //[HttpGet]
        //public async Task<ActionResult<Mastcli>> GetAll()
        //{
        //    var result = await _context.Mastcli
        //        .OrderBy(x => x.Cli_Codigo)
        //        .ToListAsync();
        //    if (!result.Any()) { return NotFound(); }
        //    return Ok(result);
        //}

        [HttpGet("{top:int?}")]
        public async Task<ActionResult<Mastcli>> GetTop(int top=300)
        {
            var result = await _context.Mastcli
                .OrderBy(x => x.Cli_Codigo)
                .Take(top)
                .ToListAsync();
            
            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<Mastcli>> GetByCode(string codigo)
        {
            var result = await _context.Mastcli
                .Where(x => x.Cli_Codigo == codigo)
                .ToListAsync();

            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }

        [HttpGet("{nombre}")]
        public async Task<ActionResult<Mastcli>> GetByName(string nombre)
        {
            var result = await _context.Mastcli
                .Where(x => x.Cli_Nombre == nombre)
                .ToListAsync();

            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }

    }
}
