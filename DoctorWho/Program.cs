using DoctorWho.DB;
using DoctorWho.DB.Models;
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
            AddDoctor(d1);
            int id = 1;
            UpdateDoctor(id ,d2);
            DeleteDoctor(2);
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
            AddeEpisode(e);
            UpdateEpisode(1003 ,d1);
            //    DeleteEpisode(e.EpisodeId);
            AddEnemy(enemy);
            AddEnemyToEpisode(enemy ,e);
            //DeleteAuthor(2);

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


        public static void AddDoctor(Doctor doctor)
            {

            context.Doctors.Add(doctor);
            context.SaveChanges();
            }

        public static void UpdateDoctor(int id ,DoctorDto d)
            {

            var x = context.Doctors.Find(id);
            if( x == null ) throw new Exception("id is not exist");
            x.DoctorName = d.DoctorName;

            x.BirthDate = DateTime.Now;
            x.FirstEpisodeDate = new DateTime(1900 ,04 ,16);
            x.LastEpisodeDate = new DateTime(2030 ,11 ,11);

            context.SaveChanges();
            }
        public static void DeleteDoctor(int id)
            {
            //DELETE DOCTOR ALSO DELETE RELATED EPISODE
            var x = context.Doctors.Find(id);
            if( x == null ) return; //throw new Exception("id is not exist");
            context.Doctors.Remove(x);
            context.SaveChanges();

            }
        public static void AddeEpisode(Episode episode)
            {

            context.Episodes.Add(episode);
            context.SaveChanges();
            }
        public static void UpdateEpisode(int id ,Doctor doctor)
            {
            var x = context.Episodes.Find(id);
            if( x == null ) return;
            x.Doctor = doctor;
            context.SaveChanges();
            }
        public static void DeleteEpisode(int id)
            {
            var x = context.Episodes.Find(id);
            if( x == null ) return;
            context.Episodes.Remove(x);
            context.SaveChanges();
            }

        public static void AddEnemy(Enemy enemy)
            {
            var x = context.Add(enemy);
            context.SaveChanges();
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
        public static void DeleteAuthor(int id)
            {


            //var x = context.Authors.Find(id);
            var x = context.Authors.Where(d => d.AuthorId == 1).First();
            var episodes = x.Episodes.ToList();
            foreach( var episode in episodes )
                {
                context.Episodes.Remove(episode);

                }
            if( x == null ) return;
            context.Authors.Remove(x);
            context.SaveChanges();
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

