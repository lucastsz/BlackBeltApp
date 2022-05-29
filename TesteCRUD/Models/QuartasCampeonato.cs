using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("QuartasCampeonato")]
    public class QuartasCampeonato
    {
        [Column("id_quarta")]
        [Display(Name = "Codigo Quarta")]
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

        [Column("id_aluno5")]
        [Display(Name = "Codigo Aluno 5")]
        public int id_aluno5 { get; set; }

        [Column("id_aluno6")]
        [Display(Name = "Codigo Aluno 6")]
        public int id_aluno6 { get; set; }

        [Column("id_aluno7")]
        [Display(Name = "Codigo Aluno 7")]
        public int id_aluno7 { get; set; }

        [Column("id_aluno8")]
        [Display(Name = "Codigo Aluno 8")]
        public int id_aluno8 { get; set; }
    }
}
