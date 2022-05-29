using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlackBeltApp.Models
{
    public class Responsavel
    {
        [Column("id_responsavel")]
        [Display(Name = "Codigo Responsavel")]
        public int Id { get; set; }
        [Column("nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Column("sobrenome")]
        [Display(Name = "Sobrenome")]
        public string sobrenome { get; set; }
        [Column("email")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Column("celular")]
        [Display(Name = "Celular")]
        public string celular { get; set; }

    }
}
