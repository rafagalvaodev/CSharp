using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFilmes.Data;
using ApiFilmes.Dtos;
using ApiFilmes.Entities;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace ApiFilmes.Controller
{
    /// <summary>
    ///     Principal controller da API
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private MovieContext _movieContext;
        private IMapper _mapper;

        /// <summary>
        /// O Construtor da controller
        /// </summary>
        public MovieController(MovieContext movieContext, IMapper mapper)
        {
            _movieContext = movieContext;
            _mapper = mapper;
        }


        /// <summary>
        ///     Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="movieDto">
        ///     Objeto com os campos necessários para a criação de um filme 
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso inserção seja realizada com sucesso </response>

        [HttpPost]
        public IActionResult AddMovie([FromBody] CreateMovieDTO movieDto)
        {
            Movie movie = _mapper.Map<Movie>(movieDto);
            _movieContext.Movies.Add(movie);
            _movieContext.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);

        }

        /// <summary>
        ///     Retorna uma lista de filmes 
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
        public IEnumerable<ReadMovieDTO> GetMovies([FromQuery] int skip = 0,
             [FromQuery] int take = 10,
             [FromQuery] string? nameCinema = null)
        {
            if (nameCinema == null)
            {
                return _mapper.Map<List<ReadMovieDTO>>(_movieContext.Movies.Skip(skip).Take(take).ToList());
            }
            return _mapper.Map<List<ReadMovieDTO>>(_movieContext.Movies
                .Skip(skip)
                .Take(take)
                .Where(movie => movie.Sessions.Any(session => session.Cinema.Name == nameCinema))
                .ToList());
        }


        /// <summary>
        ///     Retorna um filme por id
        /// </summary>
        /// <param name="id">
        ///     Usado para retornar o filme do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="200"> Caso retorno com sucesso </response>

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            Movie? movie = _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);

            ReadMovieDTO readMovieDTO = _mapper.Map<ReadMovieDTO>(movie);

            return movie == null ? NotFound() : Ok(readMovieDTO);

        }

        /// <summary>
        ///     Atualiza um filme por id
        /// </summary>
        /// /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     PUT /movie/1
        ///     {
        ///        "titulo": "Novo Nome",
        ///        "diretor": "Novo Diretor",
        ///        "duracao": 120
        ///     }
        /// 
        /// </remarks>
        /// <param name="id">Id do filme a ser atualizado </param>
        /// <param name="movieDTO">
        ///     Objeto usado para atualizar inteiramente um filme do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="204"> Filme atualizado com sucesso </response>
        /// <response code="404">Caso o filme com o ID informado não exista</response>


        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDTO movieDTO)
        {
            Movie? movie = _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null) return NotFound();
            _mapper.Map(movieDTO, movie);
            _movieContext.SaveChanges();
            return NoContent();
        }

        /// <summary>
        ///     Atualiza um filme por id
        /// </summary>
        /// <param name="id">Id do filme a ser atualizado </param>
        /// <param name="movieDTOPatch">
        ///     Objeto usado para atualizar parcialmente um filme do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="204"> Filme atualizado com sucesso </response>
        /// <response code="404">Caso o filme com o ID informado não seja encontrado.</response>
        /// <response code="400">Caso o documento de patch esteja malformado ou inválido.</response>

        [HttpPatch("{id}")]
        public IActionResult UpdateMoviePatch(int id, JsonPatchDocument<UpdateMovieDTO> movieDTOPatch)
        {
            Movie? movie = _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null) return NotFound();

            UpdateMovieDTO movieToUpdate = _mapper.Map<UpdateMovieDTO>(movie);
            movieDTOPatch.ApplyTo(movieToUpdate, ModelState);

            if (!TryValidateModel(movieToUpdate)) return ValidationProblem(ModelState);

            _mapper.Map(movieToUpdate, movie);
            _movieContext.SaveChanges();
            return NoContent();
        }

        /// <summary>
        ///     Remove um filme do banco de dados utilizando o ID.
        /// </summary>
        /// <param name="id">ID numérico do filme que deseja remover.</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Filme removido com sucesso.</response>
        /// <response code="404">Caso não exista um filme com o ID informado.</response>

        [HttpDelete("{id}")]
        public IActionResult RemoveMovie(int id)
        {
            Movie? movie = _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null) return NotFound();

            _movieContext.Remove(movie);
            _movieContext.SaveChanges();
            return NoContent();

        }
    }
}