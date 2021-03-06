﻿// <auto-generated />
using System;
using EduX_Proj.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduX_Proj.Migrations
{
    [DbContext(typeof(EduXContext))]
    [Migration("20201102032358_AlterTableUsuario")]
    partial class AlterTableUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduX_Proj.Domains.AlunoTurma", b =>
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
                        .HasName("PK__AlunoTur__8F3223BDF6274F53");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("AlunoTurma");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdCategoria")
                        .HasName("PK__Categori__A3C02A10A004AF0B");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Curso", b =>
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
                        .HasName("PK__Curso__085F27D68675BA70");

                    b.HasIndex("IdInstituicao");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Curtida", b =>
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
                        .HasName("PK__Curtida__2169583A849A9579");

                    b.HasIndex("IdDica");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Curtida");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Dica", b =>
                {
                    b.Property<int>("IdDica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Texto")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdDica")
                        .HasName("PK__Dica__F168851649041497");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Dica");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Instituicao", b =>
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
                        .HasName("PK__Institui__B771C0D865A2BB02");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Objetivo", b =>
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
                        .HasName("PK__Objetivo__E210F07129FA9642");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Objetivo");
                });

            modelBuilder.Entity("EduX_Proj.Domains.ObjetivoAluno", b =>
                {
                    b.Property<int>("IdObjetivoAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAlcancado")
                        .HasColumnType("datetime");

                    b.Property<int>("IdAlunoTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdObjetivo")
                        .HasColumnName("IdOBjetivo")
                        .HasColumnType("int");

                    b.Property<decimal>("Nota")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("IdObjetivoAluno")
                        .HasName("PK__Objetivo__81E21D7A0DC794E8");

                    b.HasIndex("IdAlunoTurma");

                    b.HasIndex("IdObjetivo");

                    b.ToTable("ObjetivoAluno");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Perfil", b =>
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
                        .HasName("PK__Perfil__C7BD5CC1504793AB");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("EduX_Proj.Domains.ProfessorTurma", b =>
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
                        .HasName("PK__Professo__D4E74F9E948564D1");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ProfessorTurma");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Turma", b =>
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
                        .HasName("PK__Turma__C1ECFFC9CCCE7D80");

                    b.HasIndex("IdCurso");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("EduX_Proj.Domains.Usuario", b =>
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
                        .HasName("PK__Usuario__5B65BF973D8C25C6");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EduX_Proj.Domains.AlunoTurma", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Turma", "IdTurmaNavigation")
                        .WithMany("AlunoTurma")
                        .HasForeignKey("IdTurma")
                        .HasConstraintName("FK__AlunoTurm__IdTur__534D60F1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_Proj.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("AlunoTurma")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__AlunoTurm__IdUsu__52593CB8")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Curso", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Instituicao", "IdInstituicaoNavigation")
                        .WithMany("Curso")
                        .HasForeignKey("IdInstituicao")
                        .HasConstraintName("FK__Curso__IdInstitu__45F365D3")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Curtida", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Dica", "IdDicaNavigation")
                        .WithMany("Curtida")
                        .HasForeignKey("IdDica")
                        .HasConstraintName("FK__Curtida__IdDica__4316F928")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_Proj.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("Curtida")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Curtida__IdUsuar__4222D4EF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Dica", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("Dica")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Dica__IdUsuario__3F466844")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Objetivo", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Categoria", "IdCategoriaNavigation")
                        .WithMany("Objetivo")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK__Objetivo__IdCate__4BAC3F29")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.ObjetivoAluno", b =>
                {
                    b.HasOne("EduX_Proj.Domains.AlunoTurma", "IdAlunoTurmaNavigation")
                        .WithMany("ObjetivoAluno")
                        .HasForeignKey("IdAlunoTurma")
                        .HasConstraintName("FK__ObjetivoA__IdAlu__571DF1D5")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_Proj.Domains.Objetivo", "IdObjetivoNavigation")
                        .WithMany("ObjetivoAluno")
                        .HasForeignKey("IdObjetivo")
                        .HasConstraintName("FK__ObjetivoA__IdOBj__5812160E")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.ProfessorTurma", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Turma", "IdTurmaNavigation")
                        .WithMany("ProfessorTurma")
                        .HasForeignKey("IdTurma")
                        .HasConstraintName("FK__Professor__IdTur__4F7CD00D")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_Proj.Domains.Usuario", "IdUsuarioNavigation")
                        .WithMany("ProfessorTurma")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Professor__IdUsu__4E88ABD4")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Turma", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Instituicao", "IdCursoNavigation")
                        .WithMany("Turma")
                        .HasForeignKey("IdCurso")
                        .HasConstraintName("FK__Turma__IdCurso__48CFD27E")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_Proj.Domains.Usuario", b =>
                {
                    b.HasOne("EduX_Proj.Domains.Perfil", "IdPerfilNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdPerfil")
                        .HasConstraintName("FK__Usuario__IdPerfi__3C69FB99")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
