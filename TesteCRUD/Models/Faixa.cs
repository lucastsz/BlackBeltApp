using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("Faixa")]
    public class Faixa
    {
        [Column("id_faixa")]
        [Display(Name = "Codigo Faixa")]
        public int Id { get; set; }

        [Column("nivel_max_faixa")]
        [Display(Name = "Nivel Maximo Faixa")]
        public int nivel_max_faixa { get; set; }

        [Column("nivel_min_faixa")]
        [Display(Name = "Nivel Minimo Faixa")]
        public int nivel_min_faixa { get; set; }

        [Column("nivel_aula_faixa")]
        [Display(Name = "Nivel Aula Faixa")]
        public int nivel_aula_faixa { get; set; }
    }
}
