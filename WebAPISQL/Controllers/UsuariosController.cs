using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISQL.Models;
using WebAPISQL.Context;

namespace WebAPISQL.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Usuario>> GetAll()
        {

            var result = await _context.Usuarios.OrderBy(x => x.User_Usuario).ToListAsync();

            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }


        [HttpGet("{usuario}")]
        public async Task<ActionResult<Usuario>> GetByUsuario(string usuario)
        {
            var result = await _context.Usuarios.Where(x => x.User_Usuario == usuario).ToListAsync();

            if (!result.Any()) { return NotFound(); }

            return Ok(result);
        }

    }
}
