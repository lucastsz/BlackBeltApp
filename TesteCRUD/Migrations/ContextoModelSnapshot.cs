// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BlackBeltApp.Models;

#nullable disable

namespace BlackBeltApp.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlackBeltApp.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_aluno");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_faixa")
                        .HasColumnType("int")
                        .HasColumnName("id_faixa");

                    b.Property<int>("id_usuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<string>("telefone_aluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefone_aluno");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_aula");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("anotacao_aula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("anotacao_aula");

                    b.Property<DateTime>("data_aula")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_aula");

                    b.Property<int>("id_mestre")
                        .HasColumnType("int")
                        .HasColumnName("id_mestre");

                    b.HasKey("Id");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_campeonato");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_final")
                        .HasColumnType("int")
                        .HasColumnName("id_final");

                    b.Property<int>("id_quarta")
                        .HasColumnType("int")
                        .HasColumnName("id_quarta");

                    b.Property<int>("id_semi")
                        .HasColumnType("int")
                        .HasColumnName("id_semi");

                    b.Property<int>("id_vencedor")
                        .HasColumnType("int")
                        .HasColumnName("id_vencedor");

                    b.HasKey("Id");

                    b.ToTable("Campeonato");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Faixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_faixa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("nivel_aula_faixa")
                        .HasColumnType("int")
                        .HasColumnName("nivel_aula_faixa");

                    b.Property<int>("nivel_max_faixa")
                        .HasColumnType("int")
                        .HasColumnName("nivel_max_faixa");

                    b.Property<int>("nivel_min_faixa")
                        .HasColumnType("int")
                        .HasColumnName("nivel_min_faixa");

                    b.HasKey("Id");

                    b.ToTable("Faixa");
                });

            modelBuilder.Entity("BlackBeltApp.Models.FaixaGraduacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_graduacao_faixa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("data_graduacao_faixa")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_graduacao_faixa");

                    b.Property<int>("id_aluno")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno");

                    b.Property<int>("id_faixa")
                        .HasColumnType("int")
                        .HasColumnName("id_faixa");

                    b.Property<int>("nivel_faixa")
                        .HasColumnType("int")
                        .HasColumnName("nivel_faixa");

                    b.HasKey("Id");

                    b.ToTable("FaixaGraduacao");
                });

            modelBuilder.Entity("BlackBeltApp.Models.FinalCampeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_final");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_aluno1")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno1");

                    b.Property<int>("id_aluno2")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno2");

                    b.HasKey("Id");

                    b.ToTable("FinalCampeonato");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Mestre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_mestre");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_usuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.HasKey("Id");

                    b.ToTable("Mestre");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("BlackBeltApp.Models.QuartasCampeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_quarta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("id_aluno1")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno1");

                    b.Property<int>("id_aluno2")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno2");

                    b.Property<int>("id_aluno3")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno3");

                    b.Property<int>("id_aluno4")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno4");

                    b.Property<int>("id_aluno5")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno5");

                    b.Property<int>("id_aluno6")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno6");

                    b.Property<int>("id_aluno7")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno7");

                    b.Property<int>("id_aluno8")
                        .HasColumnType("int")
                        .HasColumnName("id_aluno8");

                    b.HasKey("Id");

                    b.ToTable("QuartasCampeonato");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_responsavel");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("celular");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("BlackBeltApp.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("data_nascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("senha");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sobrenome");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("tipo");

                    b.Property<string>("url_foto_perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("url_foto_perfil");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
