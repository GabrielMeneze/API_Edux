﻿// <auto-generated />
using System;
using APIEdux.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIEdux.Migrations
{
    [DbContext(typeof(EduxContext))]
    partial class EduxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIEdux.Domains.AlunoTurma", b =>
                {
                    b.Property<int>("IdAlunoTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdAlunoTurma")
                        .HasName("PK__AlunoTur__8F3223BD0CF58FC4");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("AlunoTurma");
                });

            modelBuilder.Entity("APIEdux.Domains.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdCategoria")
                        .HasName("PK__Categori__A3C02A10A193400C");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("APIEdux.Domains.Curso", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdInstituicao")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdCurso")
                        .HasName("PK__Curso__085F27D6A7F4D9F3");

                    b.HasIndex("IdInstituicao");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("APIEdux.Domains.Curtida", b =>
                {
                    b.Property<int>("IdCurtida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDica")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdCurtida")
                        .HasName("PK__Curtida__2169583A9C07BD02");

                    b.HasIndex("IdDica");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Curtida");
                });

            modelBuilder.Entity("APIEdux.Domains.Dica", b =>
                {
                    b.Property<int>("IdDica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("UrlImagem")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdDica")
                        .HasName("PK__Dica__F16885163688F8D3");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Dica");
                });

            modelBuilder.Entity("APIEdux.Domains.Instituicao", b =>
                {
                    b.Property<int>("IdInstituicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Cep")
                        .HasColumnName("CEP")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Uf")
                        .HasColumnName("UF")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("IdInstituicao")
                        .HasName("PK__Institui__B771C0D8431FD5E5");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("APIEdux.Domains.Objetivo", b =>
                {
                    b.Property<int>("IdObjetivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.HasKey("IdObjetivo")
                        .HasName("PK__Objetivo__E210F07171378712");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Objetivo");
                });

            modelBuilder.Entity("APIEdux.Domains.ObjetivoAluno", b =>
                {
                    b.Property<int>("IdObjetivoAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlcancado")
                        .HasColumnType("datetime");

                    b.Property<int>("IdAlunoTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdObjetivo")
                        .HasColumnType("int");

                    b.Property<decimal?>("Nota")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("IdObjetivoAluno")
                        .HasName("PK__Objetivo__81E21D7AB4738120");

                    b.HasIndex("IdAlunoTurma");

                    b.HasIndex("IdObjetivo");

                    b.ToTable("ObjetivoAluno");
                });

            modelBuilder.Entity("APIEdux.Domains.Perfil", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Permissao")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdPerfil")
                        .HasName("PK__Perfil__C7BD5CC1C32467F5");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("APIEdux.Domains.ProfessorTurma", b =>
                {
                    b.Property<int>("IdProfessorTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdProfessorTurma")
                        .HasName("PK__Professo__D4E74F9E38B5B411");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ProfessorTurma");
                });

            modelBuilder.Entity("APIEdux.Domains.Turma", b =>
                {
                    b.Property<int>("IdTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.HasKey("IdTurma")
                        .HasName("PK__Turma__C1ECFFC9E14B5020");

                    b.HasIndex("IdCurso");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("APIEdux.Domains.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97E9445BB3");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("APIEdux.Domains.AlunoTurma", b =>
                {
                    b.HasOne("APIEdux.Domains.Turma", "IdTurmaNavigation")
                        .WithMany("AlunoTurma")
                        .HasForeignKey("IdTurma")
                        .HasConstraintName("FK__AlunoTurm__IdTur__4AB81AF0")
                        .IsRequired();

                    b.HasOne("APIEdux.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("AlunoTurma")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__AlunoTurm__IdUsu__49C3F6B7")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Curso", b =>
                {
                    b.HasOne("APIEdux.Domains.Instituicao", "IdInstituicaoNavigation")
                        .WithMany("Curso")
                        .HasForeignKey("IdInstituicao")
                        .HasConstraintName("FK__Curso__IdInstitu__440B1D61")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Curtida", b =>
                {
                    b.HasOne("APIEdux.Domains.Dica", "IdDicaNavigation")
                        .WithMany("Curtida")
                        .HasForeignKey("IdDica")
                        .HasConstraintName("FK__Curtida__IdDica__3F466844")
                        .IsRequired();

                    b.HasOne("APIEdux.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("Curtida")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Curtida__IdUsuar__3E52440B")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Dica", b =>
                {
                    b.HasOne("APIEdux.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("Dica")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Dica__IdUsuario__3B75D760")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Objetivo", b =>
                {
                    b.HasOne("APIEdux.Domains.Categoria", "IdCategoriaNavigation")
                        .WithMany("Objetivo")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK__Objetivo__IdCate__534D60F1")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.ObjetivoAluno", b =>
                {
                    b.HasOne("APIEdux.Domains.AlunoTurma", "IdAlunoTurmaNavigation")
                        .WithMany("ObjetivoAluno")
                        .HasForeignKey("IdAlunoTurma")
                        .HasConstraintName("FK__ObjetivoA__IdAlu__571DF1D5")
                        .IsRequired();

                    b.HasOne("APIEdux.Domains.Objetivo", "IdObjetivoNavigation")
                        .WithMany("ObjetivoAluno")
                        .HasForeignKey("IdObjetivo")
                        .HasConstraintName("FK__ObjetivoA__IdObj__5812160E")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.ProfessorTurma", b =>
                {
                    b.HasOne("APIEdux.Domains.Turma", "IdTurmaNavigation")
                        .WithMany("ProfessorTurma")
                        .HasForeignKey("IdTurma")
                        .HasConstraintName("FK__Professor__IdTur__4E88ABD4")
                        .IsRequired();

                    b.HasOne("APIEdux.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("ProfessorTurma")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Professor__IdUsu__4D94879B")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Turma", b =>
                {
                    b.HasOne("APIEdux.Domains.Curso", "IdCursoNavigation")
                        .WithMany("Turma")
                        .HasForeignKey("IdCurso")
                        .HasConstraintName("FK__Turma__IdCurso__46E78A0C")
                        .IsRequired();
                });

            modelBuilder.Entity("APIEdux.Domains.Usuario", b =>
                {
                    b.HasOne("APIEdux.Domains.Perfil", "IdPerfilNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdPerfil")
                        .HasConstraintName("FK__Usuario__IdPerfi__38996AB5")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
