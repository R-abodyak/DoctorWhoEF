using DoctorWho. DB;
using Microsoft. EntityFrameworkCore;
using System;
using System. Linq;


namespace DoctorWho
    {
    public class Program
        {
        static DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();


        public static void Main(string[] args)
            {
            DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
            //context. Database. EnsureCreated();

            int user = 2;


            //  string userEnemies = DoctorWhoCoreDbContext. fnCompanion(user);

            //view 
            //var v = context. ViewEpisodes. ToList();
            //foreach( var episode in v )
            //    {
            //    Console. WriteLine(episode);
            //    }

            //Console. WriteLine(userEnemies);

            //var X = context. Companions. FromSqlRaw(" exec dbo.spSummariseEpisodes"). ToList();
            //foreach( var x in X )
            //    {
            //    Console. WriteLine(x. CompanionName);
            //    }




            // var x = context. Companions. FromSqlRaw<string>("select [dbo].fnCompanion(1)"). firstOrDefult();
            // context. Companions. FromSqlRaw("select [dbo].fnCompanion(1)");
            // Console. WriteLine("x" + x);

            ExecFunc();
            LoadData();

            }
        public static string ExecFunc()
            {
            //1)excute our func in that way is not possible 
            // var x = context. Doctors. FromSqlRaw("SELECT DoctorNumber FROM Doctors"). ToList();
            //context. Companions. FromSqlRaw("select [dbo].fnCompanion(1)"). ToList();
            //The required column 'CompanionID' was not present in the results of a 'FromSql

            //2)HOW TO GET RESULT ?
            // var x = context. KeylessEntity. FromSqlRaw("select[dbo]. fnCompanion(3)");
            //Console. WriteLine("x=" + x);
            //return x;
            return string. Empty;
            }

        public static void LoadData()
            {
            var row = context. Doctors. OrderBy(d => d. DoctorId). FirstOrDefault();
            row. Episodes. Select(s => s. Notes);
            var row2 = context. Doctors. Include(b => b. Episodes). FirstOrDefault();
            row2. Episodes. Select(s => s. Notes);
            }

        }
    }

