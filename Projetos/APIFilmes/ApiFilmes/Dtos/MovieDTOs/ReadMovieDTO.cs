using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a leitura de um filme.
    /// </summary>
    public class ReadMovieDTO
    {
        /// <summary>
        ///     Id do filme
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Nome do filme
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        ///     Genero do filme
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Duração do filme
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Tempo data 
        /// </summary>
        public DateTime dateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Lista de sessões 
        /// </summary>        
        public ICollection<ReadSessionDTO>? Sessions { get; set; }
    }
}