using Microsoft.EntityFrameworkCore;
using BlackBeltApp.Models;

namespace BlackBeltApp.Models
{
    public class Contexto : DbContext
    {

        public Contexto( DbContextOptions<Contexto> options):base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Faixa> Faixa { get; set; }
        public DbSet<FaixaGraduacao> FaixaGraduacao { get; set; }
        public DbSet<Mestre> Mestre { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<BlackBeltApp.Models.Aula>? Aula { get; set; }
        public DbSet<BlackBeltApp.Models.Campeonato>? Campeonato { get; set; }
        public DbSet<BlackBeltApp.Models.FinalCampeonato>? FinalCampeonato { get; set; }
        public DbSet<BlackBeltApp.Models.QuartasCampeonato>? QuartasCampeonato { get; set; }
        public DbSet<BlackBeltApp.Models.Responsavel>? Responsavel { get; set; }
        public DbSet<BlackBeltApp.Models.SemiCampeonato>? SemiCampeonato { get; set; }
    }
}
