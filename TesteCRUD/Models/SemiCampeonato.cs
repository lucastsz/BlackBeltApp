using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("SemiCampeonato")]
    public class SemiCampeonato
    {
        [Column("id_semi")]
        [Display(Name = "Codigo Semi")]
        public int Id { get; set; }

        [Column("id_aluno1")]
        [Display(Name = "Codigo Aluno 1")]
        public int id_aluno1 { get; set; }

        [Column("id_aluno2")]
        [Display(Name = "Codigo Aluno 2")]
        public int id_aluno2 { get; set; }

        [Column("id_aluno3")]
        [Display(Name = "Codigo Aluno 3")]
        public int id_aluno3 { get; set; }

        [Column("id_aluno4")]
        [Display(Name = "Codigo Aluno 4")]
        public int id_aluno4 { get; set; }
    }
}
