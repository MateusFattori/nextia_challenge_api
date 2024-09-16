using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nextia_challenge_api.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Produto { get; set; }

        [Required]
        public string NomePromocao { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DATE")]
        public DateTime DtInicio { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DATE")]
        public DateTime DtFinal { get; set; }
    }
}
