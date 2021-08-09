using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do filme precisa ser preenchido.")]    
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O título do filme precisa ter no mínimo 3 caracteres e no máximo 60 caracteres")]
        [Display(Name ="Título do filme")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O data do filme precisa ser preenchida.")]
        [Display(Name ="Data do filme")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "O gênero do filme precisa ser preenchido.")]
        [Display(Name ="Gênero")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "O preço do filme precisa ser preenchido.")]
        [Display(Name ="Preço do filme")]
        [Range(10,300, ErrorMessage ="O valor precisa estar entre 10 e 300")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        
        
    }
}
