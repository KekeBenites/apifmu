// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apifmu.Data;

namespace apifmu.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("apifmu.Models.Adoption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("DisapprovalReason")
                        .HasColumnType("longtext");

                    b.Property<int>("OngsId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("situation")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("OngsId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("adoption");
                });

            modelBuilder.Entity("apifmu.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<int>("OngsId")
                        .HasColumnType("int");

                    b.Property<string>("Personalidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Size")
                        .HasColumnType("longtext");

                    b.Property<bool>("StatusAdocao")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OngsId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("animal");
                });

            modelBuilder.Entity("apifmu.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext");

                    b.Property<string>("Profissao")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("apifmu.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Complemnto")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("apifmu.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mensagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("forum");
                });

            modelBuilder.Entity("apifmu.Models.ForumResposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<string>("Mensagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ForumId");

                    b.ToTable("forumresposta");
                });

            modelBuilder.Entity("apifmu.Models.Ongs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Long")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.ToTable("ongs");
                });

            modelBuilder.Entity("apifmu.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("pessoa");
                });

            modelBuilder.Entity("apifmu.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Long")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int?>("OngsId")
                        .HasColumnType("int");

                    b.Property<bool?>("Quintal")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Renda")
                        .HasColumnType("longtext");

                    b.Property<string>("Residencia")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<string>("TamanhoResidencia")
                        .HasColumnType("longtext");

                    b.Property<bool?>("Tela")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("OngsId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("apifmu.Models.UsuarioDados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Batimento")
                        .HasColumnType("int");

                    b.Property<int>("Oxigenio")
                        .HasColumnType("int");

                    b.Property<int>("Passos")
                        .HasColumnType("int");

                    b.Property<string>("Sono")
                        .HasColumnType("longtext");

                    b.Property<string>("Stress")
                        .HasColumnType("longtext");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("usuariodados");
                });

            modelBuilder.Entity("apifmu.Models.Adoption", b =>
                {
                    b.HasOne("apifmu.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apifmu.Models.Ongs", "Ong")
                        .WithMany()
                        .HasForeignKey("OngsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apifmu.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Ong");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apifmu.Models.Animal", b =>
                {
                    b.HasOne("apifmu.Models.Ongs", "Ong")
                        .WithMany()
                        .HasForeignKey("OngsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apifmu.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Ong");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("apifmu.Models.Forum", b =>
                {
                    b.HasOne("apifmu.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("apifmu.Models.ForumResposta", b =>
                {
                    b.HasOne("apifmu.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apifmu.Models.Forum", "Forum")
                        .WithMany()
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Forum");
                });

            modelBuilder.Entity("apifmu.Models.Usuario", b =>
                {
                    b.HasOne("apifmu.Models.Ongs", "Ong")
                        .WithMany()
                        .HasForeignKey("OngsId");

                    b.Navigation("Ong");
                });

            modelBuilder.Entity("apifmu.Models.UsuarioDados", b =>
                {
                    b.HasOne("apifmu.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
