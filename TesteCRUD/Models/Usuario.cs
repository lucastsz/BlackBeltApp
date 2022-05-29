using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBeltApp.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Column("id_usuario")]
        [Display(Name = "Codigo")]
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

        [Column("senha")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Column("tipo")]
        [Display(Name = "Tipo")]
        public char tipo { get; set; }

        [Column("data_nascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime data_nascimento { get; set; }

        [Column("url_foto_perfil")]
        [Display(Name = "URL foto perfil")]
        public string url_foto_perfil { get; set; }

    }
}
