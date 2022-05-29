using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("Aluno")]
    public class Aluno
    {

        [Column("id_aluno")]
        [Display(Name = "Codigo Aluno")]
        public int Id { get; set; }

        [Column("id_usuario")]
        [Display(Name = "Codigo Usuario")]
        public int id_usuario { get; set; }

        [Column("id_faixa")]
        [Display(Name = "Codigo Faixa")]
        public int id_faixa { get; set; }

        [Column("telefone_aluno")]
        [Display(Name = "Telefone Aluno")]
        public string telefone_aluno { get; set; }

    }
}
