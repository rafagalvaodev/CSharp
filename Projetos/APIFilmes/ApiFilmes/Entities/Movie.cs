using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Entities
{
    /// <summary>
    ///     Entitie Movie
    /// </summary>
    [Table("movies")]
    public class Movie
    {
        /// <summary>
        ///  Id 
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        ///     name
        /// </summary>
        [Required(ErrorMessage = "O titulo é obrigatorio")]
        public string? Name { get; set; }

        /// <summary>
        ///     genero
        /// </summary>

        [Required(ErrorMessage = "O genero é obrigatorio")]
        [MaxLength(75, ErrorMessage = "O genero deve ter até 75 caracteres")]
        public string? Genre { get; set; }

        /// <summary>
        ///     duração
        /// </summary>

        [Required]
        [Range(85, 600, ErrorMessage = "A duração deve ter entre 85 e 600 minutos")]
        public int Duration { get; set; }

        /// <summary>
        ///     virtual lista de sessões
        /// </summary>
        public virtual ICollection<Session>? Sessions { get; set; }


    }
}