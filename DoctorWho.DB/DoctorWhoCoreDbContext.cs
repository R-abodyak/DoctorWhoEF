using System;
using DoctorWho. DB. Models;
using Microsoft. EntityFrameworkCore;
using Microsoft. EntityFrameworkCore. SqlServer;

namespace DoctorWho. DB
    {
    public class DoctorWhoCoreDbContext :DbContext
        {
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder. UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoCore");
            }

        protected override void OnModelCreating(ModelBuilder builder)
            {
            base. OnModelCreating(builder);

            builder. Entity<Episode>()
                . HasOne(e => e. Author)
                . WithMany(e => e. Episodes);

            builder. Entity<EpisodeCompanion>()
                . HasOne(e => e. Episode)
                . WithMany(e => e. EpisodeCompanion);

            builder. Entity<EpisodeCompanion>()
                . HasOne(e => e. Companion)
                . WithMany(e => e. EpisodeCompanion);
            builder. Entity<EpisodeEnemy>()
                . HasOne(e => e. Episode)
                . WithMany(e => e. EpisodeEnemies);
            builder. Entity<EpisodeEnemy>()
                . HasOne(e => e. Enemy)
                . WithMany(e => e. EpisodeEnemies);

            //constrains
            builder. Entity<Episode>(). HasAlternateKey(e => e. SeriesNumber);//unique
            builder. Entity<Episode>(). HasIndex(e => e. EpisodeNumber). IsUnique();//unique
            builder. Entity<Doctor>(). HasAlternateKey(e => e. DoctorNumber);//unique




            }
        }
    }
