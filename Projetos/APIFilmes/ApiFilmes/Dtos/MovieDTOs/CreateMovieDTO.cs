using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFilmes.Dtos
{
    /// <summary>
    /// Objeto de transferência de dados para a criação de um novo filme.
    /// </summary>
    public class CreateMovieDTO
    {
        /// <summary>
        /// Id do filme
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// O título do filme.
        /// </summary>

        [Required(ErrorMessage = "O titulo é obrigatorio")]
        public string? Name { get; set; }

        /// <summary>
        /// O genero do filme.
        /// </summary>

        [Required(ErrorMessage = "O genero é obrigatorio")]
        [StringLength(75, ErrorMessage = "O genero deve ter até 75 caracteres")]
        public string? Genre { get; set; }

        /// <summary>
        /// O duração do filme.
        /// </summary>

        [Required]
        [Range(85, 600, ErrorMessage = "A duração deve ter entre 85 e 600 minutos")]
        public int Duration { get; set; }
    }
}