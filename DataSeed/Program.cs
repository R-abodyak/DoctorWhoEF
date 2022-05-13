using DoctorWho. DB;
using DoctorWho. DB. Models;
using System;
using System. Collections. Generic;

namespace DataSeed
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            DoctorWhoCoreDbContext context = new DoctorWhoCoreDbContext();
            context. Database. EnsureCreated();
            List<EpisodeEnemy> EposideEnemyJoin = new List<EpisodeEnemy>();
            List<EpisodeCompanion> EposideCompanionJoin = new List<EpisodeCompanion>();

            EposideEnemyTableSeed(EposideEnemyJoin);
            EposideCompanionTableSeed(EposideCompanionJoin);
            context. AddRange(EposideEnemyJoin);
            context. AddRange(EposideCompanionJoin);
            context. SaveChanges();

            }

        private static void EposideEnemyTableSeed(List<EpisodeEnemy> EposideEnemyJoin)
            {
            var join = new EpisodeEnemy { EnemyID = 1 , EpisodeId = 1 };
            EposideEnemyJoin. Add(join);
            EposideEnemyJoin. Add(new EpisodeEnemy { EnemyID = 2 , EpisodeId = 2 });
            EposideEnemyJoin. Add(new EpisodeEnemy { EnemyID = 3 , EpisodeId = 3 });
            EposideEnemyJoin. Add(new EpisodeEnemy { EnemyID = 4 , EpisodeId = 3 });
            EposideEnemyJoin. Add(new EpisodeEnemy { EnemyID = 5 , EpisodeId = 3 });
            }
        private static void EposideCompanionTableSeed(List<EpisodeCompanion> EposideCompanionJoin)
            {
            var join = new EpisodeCompanion { EpisodeId = 2 , CompanionID = 1 };
            EposideCompanionJoin. Add(join);
            EposideCompanionJoin. Add(new EpisodeCompanion { EpisodeId = 2 , CompanionID = 4 });
            EposideCompanionJoin. Add(new EpisodeCompanion { EpisodeId = 4 , CompanionID = 4 });
            EposideCompanionJoin. Add(new EpisodeCompanion { EpisodeId = 3 , CompanionID = 4 });
            EposideCompanionJoin. Add(new EpisodeCompanion { EpisodeId = 1 , CompanionID = 3 });
            }
        }
    }
