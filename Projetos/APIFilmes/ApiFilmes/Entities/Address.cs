using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Entities
{
    /// <summary>
    ///     Entitie Address
    /// </summary>
    [Table("address")]
    public class Address
    {
        /// <summary>
        ///     id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        ///     street
        /// </summary>
        
        [Required(ErrorMessage = "O logradouro/rua é obrigatório")]
        public string? Street { get; set; }

        /// <summary>
        ///     number
        /// </summary>
        [Required(ErrorMessage = "O numero é obrigatório")]
        public int Number { get; set; }

        /// <summary>
        ///     Vitual cinema
        /// </summary>
        public virtual Cinema? Cinema { get; set; }
    }
}