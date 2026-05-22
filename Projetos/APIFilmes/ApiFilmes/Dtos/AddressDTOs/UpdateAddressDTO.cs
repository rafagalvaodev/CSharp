using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a atualização de um endereço.
    /// </summary>
    public class UpdateAddressDTO
    {
        /// <summary>
        ///     Logradouro/rua endereço
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        ///     Numero do endereço
        /// </summary>
        public int Number { get; set; }
    }
}