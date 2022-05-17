using DoctorWho.DB;
using DoctorWho.DB.Models;
using DoctorWho.DB.Repositories;
using DoctorWho.DB.Resurces;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;



namespace DoctorWho
    {
    public class Program
        {
        static DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();


        public static void Main(string[] args)
            {
            Random rnd = new Random();
            int num = rnd.Next();
            //context. Database. EnsureCreated();
            //int user = 2;




            //view 
            var v = context.ViewEpisodes.First();
            //foreach( var episode in v )
            //    {
            //    Console. WriteLine(episode);
            //    }

            //stored procedure 
            //var X = context. Companions. FromSqlRaw(" exec dbo.spSummariseEpisodes"). ToList();
            //foreach( var x in X )
            //    {
            //    Console. WriteLine(x. CompanionName);
            //    }


            //ExecFunc();
            // LoadData();

            Doctor d1 = new Doctor()
                {
                DoctorNumber = rnd.Next() ,
                BirthDate = DateTime.Now ,
                DoctorName = "Ahmed" ,
                FirstEpisodeDate = DateTime.Now ,
                LastEpisodeDate = DateTime.Now
                };
            DoctorDto d2 = new DoctorDto()
                {
                DoctorNumber = num ,
                BirthDate = DateTime.Now ,
                DoctorName = "Rawan" ,
                FirstEpisodeDate = DateTime.Now ,
                LastEpisodeDate = DateTime.Now
                };
            DoctorRepository.AddDoctor(d1);
            int id = 1;
            DoctorRepository.UpdateDoctor(id ,d2);
            DoctorRepository.DeleteDoctor(2);


            num = rnd.Next();
            Episode e = new Episode()
                {
                SeriesNumber = rnd.Next() ,
                EpisodeNumber = rnd.Next() ,
                EpisodeType = "new type" ,
                Doctor = d1
                };
            Enemy enemy = new Enemy()
                {
                EnemyName = "new enemy name" ,
                Description = "this is new descripetion" ,


                };
            EpisodeRepository.AddeEpisode(e);
            EpisodeRepository.UpdateEpisode(1003 ,d1);
            //EpisodeRepository.DeleteEpisode(e.EpisodeId);
            EnemyRepository.AddEnemy(enemy);
            AddEnemyToEpisode(enemy ,e);
            //AuthorRepository.DeleteAuthor(2);

            }


        public static void LoadData()
            {
            //WHY WHEN i comment first one seconde one give error ,if I PUT 2 INSTEAD OF  1 :(

            var row2 = context.Doctors.Include(b => b.Episodes).FirstOrDefault();
            // row2 = context. Doctors. Find(1);
            var DoctorEpisode = row2.Episodes.Select(d => d).ToList();
            foreach( var episode in DoctorEpisode )
                {
                Console.WriteLine(episode.EpisodeId);
                }

            var row = context.Doctors.FirstOrDefault();
            //var row = context. Doctors. Find(2);

            // is that Lazy loading ?
            var DoctorEpisode2 = row.Episodes.Select(d => d.EpisodeId).ToList();
            foreach( var episode in DoctorEpisode2 )
                {
                Console.WriteLine(episode);
                }

            }







        public static void AddEnemyToEpisode(Enemy enemy ,Episode episode)
            {
            context.Add(new EpisodeEnemy { Enemy = enemy ,Episode = episode });
            context.SaveChanges();
            }
        public static void AddCompanionToEpisode(Companion companion ,Episode episode)
            {
            context.Add(new EpisodeCompanion { Companion = companion ,Episode = episode });
            context.SaveChanges();
            }
        public List<Doctor> GetAllDoctor()
            {
            var doctors = context.Doctors.ToList();
            return doctors;
            //var d =context.Doctors.Select(s => s).ToList();
            }
        public Companion GetCompanionById(int id)
            {
            var companion = context.Companions.Find(id);
            return companion;

            }





        public static string ExecFunc()
            {
            //1)excute our func in that way is not possible 
            //var x = context.Entry.FromSqlRaw<int>("SELECT DoctorNumber FROM Doctors"). ToList();
            //context. Companions. FromSqlRaw("select [dbo].fnCompanion(1)"). ToList();
            //The required column 'CompanionID' was not present in the results of a 'FromSql

            //2)HOW TO GET RESULT ?
            var x = context.Set<KeylessEntity>().FromSqlRaw("select [dbo]. fnCompanion(3) as Value").AsEnumerable().First();
            Console.WriteLine("x=" + x.Value);
            var userEnemies = context.Episodes
              .Select(s => context.fnCompanion(s.EpisodeId)).ToList();
            //return x;
            return string.Empty;
            }

        }


    }

