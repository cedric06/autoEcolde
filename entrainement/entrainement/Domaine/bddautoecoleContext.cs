using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace entrainement.Domaine
{
    public partial class bddautoecoleContext : DbContext
    {
        public bddautoecoleContext()
        {
        }

        public bddautoecoleContext(DbContextOptions<bddautoecoleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Cdrom> Cdrom { get; set; }
        public virtual DbSet<Eleves> Eleves { get; set; }
        public virtual DbSet<ElevesHasSeance> ElevesHasSeance { get; set; }
        public virtual DbSet<Examen> Examen { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<QuestionsHasSerie> QuestionsHasSerie { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<Serie> Serie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3310;user=root;password=root;database=bddautoecole", x => x.ServerVersion("10.4.8-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.ToTable("adresse");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adresse1)
                    .IsRequired()
                    .HasColumnName("adresse")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Cdrom>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("cdrom");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomEditeur)
                    .IsRequired()
                    .HasColumnName("nomEditeur")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Eleves>(entity =>
            {
                entity.ToTable("eleves");

                entity.HasIndex(e => e.AdresseId)
                    .HasName("fk_eleves_adresse1_idx");

                entity.HasIndex(e => e.ExamenId)
                    .HasName("fk_eleves_examen1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdresseId)
                    .HasColumnName("adresse_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Birth)
                    .HasColumnName("birth")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExamenId)
                    .HasColumnName("examen_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Eleves)
                    .HasForeignKey(d => d.AdresseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_eleves_adresse1");

                entity.HasOne(d => d.Examen)
                    .WithMany(p => p.Eleves)
                    .HasForeignKey(d => d.ExamenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_eleves_examen1");
            });

            modelBuilder.Entity<ElevesHasSeance>(entity =>
            {
                entity.ToTable("eleves_has_seance");

                entity.HasIndex(e => e.ElevesId)
                    .HasName("fk_eleves_has_seance_eleves1_idx");

                entity.HasIndex(e => e.SeanceId)
                    .HasName("fk_eleves_has_seance_seance1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElevesId)
                    .HasColumnName("eleves_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nbfaute)
                    .HasColumnName("nbfaute")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SeanceId)
                    .HasColumnName("seance_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Eleves)
                    .WithMany(p => p.ElevesHasSeance)
                    .HasForeignKey(d => d.ElevesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_eleves_has_seance_eleves1");

                entity.HasOne(d => d.Seance)
                    .WithMany(p => p.ElevesHasSeance)
                    .HasForeignKey(d => d.SeanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_eleves_has_seance_seance1");
            });

            modelBuilder.Entity<Examen>(entity =>
            {
                entity.ToTable("examen");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.ToTable("questions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Difficulty)
                    .IsRequired()
                    .HasColumnName("difficulty")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Intitulé)
                    .IsRequired()
                    .HasColumnName("intitulé")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Reponse)
                    .IsRequired()
                    .HasColumnName("reponse")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasColumnName("theme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<QuestionsHasSerie>(entity =>
            {
                entity.HasKey(e => new { e.QuestionsId, e.SerieId })
                    .HasName("PRIMARY");

                entity.ToTable("questions_has_serie");

                entity.HasIndex(e => e.QuestionsId)
                    .HasName("fk_questions_has_serie_questions1_idx");

                entity.HasIndex(e => e.SerieId)
                    .HasName("fk_questions_has_serie_serie1_idx");

                entity.Property(e => e.QuestionsId)
                    .HasColumnName("questions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerieId)
                    .HasColumnName("serie_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Questions)
                    .WithMany(p => p.QuestionsHasSerie)
                    .HasForeignKey(d => d.QuestionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_questions_has_serie_questions1");

                entity.HasOne(d => d.Serie)
                    .WithMany(p => p.QuestionsHasSerie)
                    .HasForeignKey(d => d.SerieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_questions_has_serie_serie1");
            });

            modelBuilder.Entity<Seance>(entity =>
            {
                entity.ToTable("seance");

                entity.HasIndex(e => e.SerieId)
                    .HasName("fk_seance_serie1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SerieId)
                    .HasColumnName("serie_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Serie)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.SerieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seance_serie1");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.ToTable("serie");

                entity.HasIndex(e => e.CdromId)
                    .HasName("fk_serie_CDrom1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CdromId)
                    .HasColumnName("CDrom_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cdrom)
                    .WithMany(p => p.Serie)
                    .HasForeignKey(d => d.CdromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_serie_CDrom1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
