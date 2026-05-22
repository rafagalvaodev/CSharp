using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testeAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("DataHoraAtual")]
        public IActionResult DataHora()
        {
            var obj = new 
            {
                dataAtual = DateTime.Now.ToLongDateString().ToUpper(),
                horaAtual = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }
        [HttpGet("Apresentação/{nome}")]
        public IActionResult Apresentacao(string nome)
        {
           
            var mensagem = $"Olá {nome}, como você está?"; 
            return Ok(new {mensagem});
        }     
    }

        
}