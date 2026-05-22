using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a criação de um novo endereço.
    /// </summary>
    public class CreateAddressDTO
    {
        /// <summary>
        /// Logradouro/rua do endereço.
        /// </summary>
        [Required(ErrorMessage = "O logradouro/rua é obrigatório")]
        public string? Street { get; set; }

        /// <summary>
        /// O numero do endereço.
        /// </summary>     
        [Required(ErrorMessage = "O numero é obrigatório")]
        public int Number { get; set; }

    }
}