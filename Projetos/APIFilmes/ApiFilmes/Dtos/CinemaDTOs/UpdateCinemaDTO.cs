using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a atualização de um cinema.
    /// </summary>
    public class UpdateCinemaDTO
    {
        /// <summary>
        /// Nome do cinema
        /// </summary>
        public string? Name { get; set; }

    }
}