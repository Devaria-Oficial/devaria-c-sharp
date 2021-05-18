using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterUsuario()
        {
            var usuario = new Usuario() { 
                Nome = "Teste",
                Email = "teste@teste.com",
                Senha = "12345ab"
            };
            return Ok(usuario);
        }
    }
}
