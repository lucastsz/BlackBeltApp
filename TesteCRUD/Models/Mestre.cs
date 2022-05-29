using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlackBeltApp.Models
{
    [Table("Mestre")]
    public class Mestre
    {
        [Column("id_mestre")]
        [Display(Name = "Codigo Mestre")]
        public int Id { get; set; }

        [Column("id_usuario")]
        [Display(Name = "Codigo Usuario")]
        public int id_usuario { get; set; }
    }
}
