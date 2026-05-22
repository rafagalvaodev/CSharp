using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a criação de um novo cinema.
    /// </summary>
    public class CreateCinemaDTO
    {
        /// <summary>
        /// O título do Cinema.
        /// </summary>
        [Key]
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string? Name { get; set; }

        /// <summary>
        /// Id do endereço do cinema.
        /// </summary>
        public int AddressId { get; set; }

    }
}