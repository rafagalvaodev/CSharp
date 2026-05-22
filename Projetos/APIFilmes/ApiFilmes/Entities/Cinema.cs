using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Entities
{
    /// <summary>
    ///     Entitie Cinema
    /// </summary>

    [Table("cinema")]
    public class Cinema
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
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public string? Name { get; set; }

        /// <summary>
        ///    Id do endereço 
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        ///     Referencia do Endereço
        /// </summary>
        public virtual Address? Address { get; set; }

        /// <summary>
        ///     Sessão
        /// </summary>
        public virtual ICollection<Session>? Sessions { get; set; }


    }
}

