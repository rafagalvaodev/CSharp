using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiFilmes.Data;
using ApiFilmes.Dtos;
using ApiFilmes.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiFilmes.Controllers
{
    /// <summary>
    ///     Controller de sessão
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SessionController : ControllerBase
    {
        private MovieContext _movieContext;
        private IMapper _mapper;

        /// <summary>
        /// O Construtor da controller
        /// </summary>
        public SessionController(MovieContext movieContext, IMapper mapper)
        {
            _movieContext = movieContext;
            _mapper = mapper;
        }

        /// <summary>
        ///     Adiciona uma sessão ao banco de dados
        /// </summary>
        /// <param name="sessionDTO">
        ///     Objeto com os campos necessários para a criação de uma sessão
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso inserção seja realizada com sucesso </response>

        [HttpPost]
        public IActionResult AddSession([FromBody] CreateSessionDTO sessionDTO)
        {
            Session session = _mapper.Map<Session>(sessionDTO);
            _movieContext.Sessions.Add(session);
            _movieContext.SaveChanges();
            return CreatedAtAction(nameof(GetSessionById), new { movieId = session.MovieId, cinemaId = session.CinemaId }, session);

        }

        /// <summary>
        ///     Retorna uma lista de sessões
        /// </summary>
        /// <param name="skip">
        ///     Pula um valor determinado  
        /// </param>
        /// <param name="take">
        ///     Pega um valor determinado      
        ///  </param>
        /// <returns>IEnumerable</returns>
        /// <response code="200"> Caso retorno com sucesso </response>

        [HttpGet]
        public IEnumerable<ReadSessionDTO> GetSession([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {

            return _mapper.Map<List<ReadSessionDTO>>(_movieContext.Sessions.Skip(skip).Take(take));

        }

        /// <summary>
        ///     Retorna uma sessão por id
        /// </summary>
        /// <param name="id">
        ///     Usado para retornar da sessão do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="200"> Caso retorno com sucesso </response>
        
        [HttpGet("{movieId}/{cinemaId}")]
        public IActionResult GetSessionById(int movieId, int cinemaId)
        {
            Session? session = _movieContext.Sessions.FirstOrDefault(session =>
                session.MovieId == movieId && session.CinemaId == cinemaId);

            ReadSessionDTO readSessionDTO = _mapper.Map<ReadSessionDTO>(session);

            return session == null ? NotFound() : Ok(readSessionDTO);

        }

        /// <summary>
        ///     Atualiza uma sessão por id
        /// </summary>
        /// /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     PUT /session/1
        ///     {
        ///        "name": "Novo Nome",
        ///     }
        /// 
        /// </remarks>
        /// <param name="id">Id da sessão a ser atualizado </param>
        /// <param name="addressDTO">
        ///     Objeto usado para atualizar inteiramente uma sessão do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Sessão atualizado com sucesso </response>
        /// <response code="404">Caso o sessão com o ID informado não exista</response>

        [HttpPut("{id}")]
        public IActionResult UpdateSession(int id, [FromBody] UpdateAddressDTO addressDTO)
        {
            Address? address = _movieContext.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null) return NotFound();
            _mapper.Map(addressDTO, address);
            _movieContext.SaveChanges();
            return NoContent();
        }

        /// <summary>
        ///     Remove um endereço do banco de dados utilizando o ID.
        /// </summary>
        /// <param name="id">ID numérico do endereço que deseja remover.</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Endereço removido com sucesso.</response>
        /// <response code="404">Caso não exista um cinema com o ID informado.</response>
        [HttpDelete("{id}")]
        public IActionResult RemoveAddress(int id)
        {
            Address? address = _movieContext.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null) return NotFound();

            _movieContext.Remove(address);
            _movieContext.SaveChanges();
            return NoContent();

        }


    }
}