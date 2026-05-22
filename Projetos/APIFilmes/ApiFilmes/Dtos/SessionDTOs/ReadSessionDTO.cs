using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a leitura de uma sessão.
    /// </summary>
    public class ReadSessionDTO
    {
        /// <summary>
        ///     Id do filme
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        ///     Id do cinema
        /// </summary>
        public int CinemaId { get; set; }

    }
}