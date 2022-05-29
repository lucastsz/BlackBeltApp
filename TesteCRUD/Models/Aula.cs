using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlackBeltApp.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Column("id_aula")]
        [Display(Name = "Codigo Aula")]
        public int Id { get; set; }
        [Column("id_mestre")]
        [Display(Name = "Codigo Mestre")]
        public int id_mestre { get; set; }
        [Column("data_aula")]
        [Display(Name = "Data Aula")]
        public DateTime data_aula { get; set; }
        [Column("anotacao_aula")]
        [Display(Name = "Anotação Aula")]
        public string anotacao_aula { get; set; }
    }
}
