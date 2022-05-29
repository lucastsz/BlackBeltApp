using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("Campeonato")]
    public class Campeonato
    {
        [Column("id_campeonato")]
        [Display(Name = "Codigo Campeonato")]
        public int Id { get; set; }

        [Column("id_quarta")]
        [Display(Name = "Codigo Quarta")]
        public int id_quarta { get; set; }

        [Column("id_semi")]
        [Display(Name = "Codigo Semi")]
        public int id_semi { get; set; }

        [Column("id_final")]
        [Display(Name = "Codigo Final")]
        public int id_final { get; set; }

        [Column("id_vencedor")]
        [Display(Name = "Codigo Vencedor")]
        public int id_vencedor { get; set; }
    }
}
