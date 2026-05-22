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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ApiFilmes.Controllers
{
    /// <summary>
    ///     Controller de cinema
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private MovieContext _movieContext;
        private IMapper _mapper;

        /// <summary>
        /// O Construtor da controller
        /// </summary>
        public CinemaController(MovieContext movieContext, IMapper mapper)
        {
            _movieContext = movieContext;
            _mapper = mapper;
        }

        /// <summary>
        ///     Adiciona um cinema ao banco de dados
        /// </summary>
        /// <param name="cinemaDto">
        ///     Objeto com os campos necessários para a criação de um cinema 
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso inserção seja realizada com sucesso </response>

        [HttpPost]
        public IActionResult AddCinema([FromBody] CreateCinemaDTO cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _movieContext.Cinemas.Add(cinema);
            _movieContext.SaveChanges();
            return CreatedAtAction(nameof(GetCinemaById), new { id = cinema.Id }, cinema);

        }

        /// <summary>
        ///     Retorna uma lista de cinemas
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
        public IEnumerable<ReadCinemaDTO> GetCinema([FromQuery] int skip = 0, [FromQuery] int take = 10, [FromQuery] int? addressId = null)
        {
            // if (addressId == null)
            // {
            //     return _mapper.Map<List<ReadCinemaDTO>>(_movieContext.Cinemas.Skip(skip).Take(take).ToList());
            // }
            // return _mapper.Map<List<ReadCinemaDTO>>(_movieContext
            //     .Cinemas
            //     .FromSqlRaw($"SELECT id, name, addressId FROM cinema WHERE cinema.addressId = {addressId}").ToList());

            var query = _movieContext.Cinemas.AsQueryable();

            // 2. Se o addressId foi passado, aplicamos o filtro WHERE de forma dinâmica
            if (addressId != null)
            {
                query = query.Where(cinema => cinema.AddressId == addressId);
            }

            // 3. Aplicamos a paginação e convertemos para lista (executa no banco com as aspas certas)
            var cinemas = query.Skip(skip).Take(take).ToList();

            // 4. Mapeamos para o DTO e retornamos
            return _mapper.Map<List<ReadCinemaDTO>>(cinemas);

        }

        /// <summary>
        ///     Retorna um cinema por id
        /// </summary>
        /// <param name="id">
        ///     Usado para retornar o cinema do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="200"> Caso retorno com sucesso </response>
        
        [HttpGet("{id}")]
        public IActionResult GetCinemaById(int id)
        {
            Cinema? cinema = _movieContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id);

            ReadCinemaDTO readCinemaDTO = _mapper.Map<ReadCinemaDTO>(cinema);

            return cinema == null ? NotFound() : Ok(readCinemaDTO);

        }

        /// <summary>
        ///     Atualiza um cinema por id
        /// </summary>
        /// /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     PUT /cinema/1
        ///     {
        ///        "name": "Novo Nome",
        ///     }
        /// 
        /// </remarks>
        /// <param name="id">Id do cinema a ser atualizado </param>
        /// <param name="cinemaDTO">
        ///     Objeto usado para atualizar inteiramente um cinema do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="204"> cinema atualizado com sucesso </response>
        /// <response code="404">Caso o cinema com o ID informado não exista</response>

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] UpdateCinemaDTO cinemaDTO)
        {
            Cinema? cinema = _movieContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null) return NotFound();
            _mapper.Map(cinemaDTO, cinema);
            _movieContext.SaveChanges();
            return NoContent();
        }

        /// <summary>
        ///     Remove um cinema do banco de dados utilizando o ID.
        /// </summary>
        /// <param name="id">ID numérico do cinema que deseja remover.</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Cinema removido com sucesso.</response>
        /// <response code="404">Caso não exista um cinema com o ID informado.</response>
        [HttpDelete("{id}")]
        public IActionResult RemoveCinema(int id)
        {
            Cinema? cinema = _movieContext.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null) return NotFound();

            _movieContext.Remove(cinema);
            _movieContext.SaveChanges();
            return NoContent();

        }


    }
}