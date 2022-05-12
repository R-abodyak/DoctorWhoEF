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
            optionsBuilder. EnableSensitiveDataLogging(true);
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
            builder. Entity<Episode>(). HasAlternateKey(e => e. SeriesNumber);//unique --this was added as constrain in mig file
            builder. Entity<Episode>(). HasIndex(e => e. EpisodeNumber). IsUnique();//unique
            builder. Entity<Doctor>(). HasAlternateKey(e => e. DoctorNumber);//unique
            //Dataseeding 
            builder. Entity<Doctor>(). HasData(
                new Doctor
                    {
                    DoctorId = 1 ,
                    DoctorNumber = 1 ,
                    DoctorName = "Hani" ,
                    FirstEpisodeDate = new DateTime(2022 , 07 , 05) ,
                    LastEpisodeDate = new DateTime(2022 , 08 , 8)
                    } ,
                new Doctor
                    {
                    DoctorId = 2 ,
                    DoctorNumber = 2 ,
                    DoctorName = "Huda" ,
                    FirstEpisodeDate = new DateTime(2022 , 07 , 08) ,
                    LastEpisodeDate = new DateTime(2022 , 08 , 8) ,
                    BirthDate = new DateTime(1970 , 7 , 7)
                    } ,
                 new Doctor
                     {
                     DoctorId = 3 ,
                     DoctorNumber = 3 ,
                     DoctorName = "Nada" ,
                     FirstEpisodeDate = new DateTime(2022 , 09 , 01) ,
                     LastEpisodeDate = new DateTime(2022 , 09 , 20) ,
                     BirthDate = new DateTime(1978 , 7 , 7)
                     } ,
                  new Doctor
                      {
                      DoctorId = 4 ,
                      DoctorNumber = 4 ,
                      DoctorName = "Ali" ,
                      FirstEpisodeDate = new DateTime(2022 , 09 , 01) ,
                      LastEpisodeDate = new DateTime(2022 , 09 , 20) ,
                      BirthDate = new DateTime(1978 , 7 , 7)
                      } ,
                  new Doctor
                      {
                      DoctorId = 5 ,
                      DoctorNumber = 5 ,
                      DoctorName = "salam" ,
                      FirstEpisodeDate = new DateTime(2022 , 09 , 01) ,
                      LastEpisodeDate = new DateTime(2022 , 09 , 20) ,
                      BirthDate = new DateTime(1978 , 7 , 7)
                      }

                );
            builder. Entity<Author>(). HasData(
                new Author { AuthorId = 1 , AuthorName = "Mohamed" } ,
                new Author { AuthorId = 2 , AuthorName = "Ahmed" } ,
                new Author { AuthorId = 3 , AuthorName = "Aseel" } ,
                new Author { AuthorId = 4 , AuthorName = "Omar" } ,
                new Author { AuthorId = 5 , AuthorName = "Marwa" }


                );
            builder. Entity<Episode>(). HasData
               (
                new Episode
                    {
                    EpisodeId = 1 ,
                    EpisodeNumber = 1 ,
                    SeriesNumber = 1 ,
                    EpisodeType = "type1" ,
                    Tittle = "tittle1" ,
                    EpisodeDate = new DateTime(2018 , 7 , 24) ,
                    DoctorId = 1 ,

                    } ,
                new Episode
                    {
                    EpisodeId = 2 ,

                    EpisodeNumber = 2 ,
                    SeriesNumber = 165 ,
                    EpisodeType = "type1" ,
                    Tittle = "tittle2" ,
                    EpisodeDate = new DateTime(2022 , 7 , 24) ,
                    DoctorId = 1 ,


                    } ,
                 new Episode
                     {
                     EpisodeId = 3 ,

                     EpisodeNumber = 3 ,
                     SeriesNumber = 188 ,
                     EpisodeType = "type1" ,
                     Tittle = "tittle1" ,
                     EpisodeDate = new DateTime(2023 , 7 , 24) ,
                     Notes = "notes3" ,
                     DoctorId = 1 ,

                     } ,
                 new Episode
                     {
                     EpisodeId = 4 ,

                     EpisodeNumber = 4 ,
                     SeriesNumber = 189 ,
                     EpisodeType = "type3" ,
                     Tittle = "tittle4" ,
                     EpisodeDate = new DateTime(2023 , 7 , 24) ,
                     Notes = "notes4" ,
                     DoctorId = 2 ,

                     } ,
                 new Episode
                     {
                     EpisodeId = 5 ,

                     EpisodeNumber = 5 ,
                     SeriesNumber = 181 ,
                     EpisodeType = "type2" ,
                     Tittle = "tittle5" ,
                     EpisodeDate = new DateTime(2023 , 7 , 24) ,
                     Notes = "notes5" ,
                     DoctorId = 3 ,

                     }
                     );

            builder. Entity<Companion>(). HasData(
                new Companion { CompanionID = 1 , CompanionName = "NAME1" , WhoPlayed = "W1" } ,
                new Companion { CompanionID = 2 , CompanionName = "NAME2" , WhoPlayed = "W2" } ,
                new Companion { CompanionID = 3 , CompanionName = "NAME3" , WhoPlayed = "W3" } ,
                new Companion { CompanionID = 4 , CompanionName = "NAME4" , WhoPlayed = "W4" } ,
                new Companion { CompanionID = 5 , CompanionName = "NAME5" , WhoPlayed = "W5" }
                );

            builder. Entity<Enemy>(). HasData(
               new Enemy { EnemyId = 1 , EnemyName = "enemy1" , Description = "this is description" } ,
               new Enemy { EnemyId = 2 , EnemyName = "enemy1" , Description = "this is description" } ,
               new Enemy { EnemyId = 3 , EnemyName = "enemy1" , Description = "this is description" } ,
               new Enemy { EnemyId = 4 , EnemyName = "enemy1" , Description = "this is description" } ,
               new Enemy { EnemyId = 5 , EnemyName = "enemy1" , Description = "this is description" }


                );


            }
        }
    }
