using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteApplication.Models;
using TesteApplication.Services.UsuariosService;

namespace TesteApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        

        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> GetAllUsers()
        {
            var result = _usuarioService.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> GetSingleUsers(int id)
        {
            var result = _usuarioService.GetSingleUsers(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Usuarios>>> AddUsers(Usuarios usuario)
        {
            var result = _usuarioService.AddUsers(usuario);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Usuarios>>> UpdateUsers( int id, Usuarios request)
        {
            var result = _usuarioService.UpdateUsers(id, request);
            if (result is null)
            {
                return NotFound("Usuário não encontrado");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuarios>>> DeleteUsers(int id)
        {
            var result = _usuarioService.DeleteUsers(id);
            if (result is null)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok(result);
        }
    }
}
