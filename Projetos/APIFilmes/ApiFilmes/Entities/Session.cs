using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Entities
{
    /// <summary>
    ///     Entitie Sessão
    /// </summary>
    [Table("session")]
    public class Session
    {
        /// <summary>
        ///  MovieId
        /// </summary>
        public int? MovieId { get; set; }

        /// <summary>
        ///  Vitural movie
        /// </summary>
        public virtual Movie? Movie { get; set; }

        /// <summary>
        ///     Id do cinema
        /// </summary>
        public int? CinemaId { get; set; }

        /// <summary>
        ///    Virtual de cinema
        /// </summary>
        public virtual Cinema? Cinema { get; set; }


    }
}