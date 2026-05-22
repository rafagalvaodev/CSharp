using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a leitura de um endereço.
    /// </summary>
    public class ReadAddressDTO
    {
        /// <summary>
        ///     id do endereço
        /// </summary>
        public int Id { get; set; }

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