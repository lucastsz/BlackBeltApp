using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("FaixaGraduacao")]
    public class FaixaGraduacao
    {
        [Column("id_graduacao_faixa")]
        [Display(Name = "Codigo Graduacao Faixa")]
        public int Id { get; set; }

        [Column("id_faixa")]
        [Display(Name = "Codigo Faixa")]
        public int id_faixa { get; set; }

        [Column("id_aluno")]
        [Display(Name = "Codigo Aluno")]
        public int id_aluno { get; set; }

        [Column("data_graduacao_faixa")]
        [Display(Name = "Data Graduacao Faixa")]
        public DateTime data_graduacao_faixa { get; set; }

        [Column("nivel_faixa")]
        [Display(Name = "Nível Faixa")]
        public int nivel_faixa { get; set; }

    }
}
