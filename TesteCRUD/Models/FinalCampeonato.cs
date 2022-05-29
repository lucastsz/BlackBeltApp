using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlackBeltApp.Models
{
    [Table("FinalCampeonato")]
    public class FinalCampeonato
    {
        [Column("id_final")]
        [Display(Name = "Codigo Final")]
        public int Id { get; set; }

        [Column("id_aluno1")]
        [Display(Name = "Codigo Aluno 1")]
        public int id_aluno1 { get; set; }

        [Column("id_aluno2")]
        [Display(Name = "Codigo Aluno 2")]
        public int id_aluno2 { get; set; }
    }
}
