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
    ///     Controller de endereço
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private MovieContext _movieContext;
        private IMapper _mapper;

        /// <summary>
        /// O Construtor da controller
        /// </summary>
        public AddressController(MovieContext movieContext, IMapper mapper)
        {
            _movieContext = movieContext;
            _mapper = mapper;
        }

        /// <summary>
        ///     Adiciona um endereço ao banco de dados
        /// </summary>
        /// <param name="addressDTO">
        ///     Objeto com os campos necessários para a criação de um endereço
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="201"> Caso inserção seja realizada com sucesso </response>

        [HttpPost]
        public IActionResult AddAddress([FromBody] CreateAddressDTO addressDTO)
        {
            Address address = _mapper.Map<Address>(addressDTO);
            _movieContext.Addresses.Add(address);
            _movieContext.SaveChanges();
            return CreatedAtAction(nameof(GetAddressById), new { id = address.Id }, address);

        }

        /// <summary>
        ///     Retorna uma lista de endereços
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
        public IEnumerable<ReadAddressDTO> GetAddress([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {

            return _mapper.Map<List<ReadAddressDTO>>(_movieContext.Addresses.Skip(skip).Take(take));

        }

        /// <summary>
        ///     Retorna um endereço por id
        /// </summary>
        /// <param name="id">
        ///     Usado para retornar o endereço do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="200"> Caso retorno com sucesso </response>

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            Address? address = _movieContext.Addresses.FirstOrDefault(address => address.Id == id);

            ReadAddressDTO readAddressDTO = _mapper.Map<ReadAddressDTO>(address);

            return address == null ? NotFound() : Ok(readAddressDTO);

        }

        /// <summary>
        ///     Atualiza um endereço por id
        /// </summary>
        /// /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     PUT /address/1
        ///     {
        ///        "street": "Novo Nome",
        ///         "number": 0
        ///     }
        /// 
        /// </remarks>
        /// <param name="id">Id do endereço a ser atualizado </param>
        /// <param name="addressDTO">
        ///     Objeto usado para atualizar inteiramente um endereço do banco  
        /// </param>
        /// <returns>IActionResult</returns>
        /// <response code="204">endereço atualizado com sucesso </response>
        /// <response code="404">Caso o endereço com o ID informado não exista</response>

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDTO addressDTO)
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
        /// <response code="404">Caso não exista um endereço com o ID informado.</response>
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