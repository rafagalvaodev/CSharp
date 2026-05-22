using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a leitura de um cinema.
    /// </summary>
    public class ReadCinemaDTO
    {
        /// <summary>
        ///     id do cinema
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Nome do cinema
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        ///     Endereço do cinema
        /// </summary>
        public ReadAddressDTO? Address { get; set; }

        /// <summary>
        /// Lista de sessões 
        /// </summary>        
        public ICollection<ReadSessionDTO>? Sessions { get; set; }
    }
}