using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiFilmes.Entities;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a criação de uma nova session.
    /// </summary>
    public class CreateSessionDTO
    {
        /// <summary>
        ///     Id do filme
        /// </summary>
        public int? MovieId { get; set; }

        /// <summary>
        ///     Id do Cinema
        /// </summary>
        public int? CinemaId { get; set; }
    }
}