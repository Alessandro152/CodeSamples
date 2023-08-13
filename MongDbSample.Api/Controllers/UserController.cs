using Microsoft.AspNetCore.Mvc;
using MongDbSample.Api.Business.Dtos;
using MongDbSample.Business.Entities;
using MongoDbSample.Infra.Repositories;
using System.Threading.Tasks;

namespace MongDbSample.Api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_userRepository.GetAllUsers());
        }

        [HttpPost("NovoUsuario")]
        public async Task<IActionResult> Gravar()
        {
            var usuario = new User("Rubens Barrichello", 54);
            usuario.AddAdress(new AdressDto { Street = "Av Candido Portinari", Number = 10, City = "Osasco", Country = "Brazil" });

            _userRepository.Insert(usuario);

            return Created(string.Empty, usuario.Id);
        }
    }
}
