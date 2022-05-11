using System;
using System. Collections. Generic;
using System. Text;

namespace DoctorWho. DB. Models
    {
    public class EpisodeCompanion
        {
        public int EpisodeCompanionId { get; set; }

        //ref let see without Fk will it work ?
        public Episode Episode { get; set; }
        public Companion Companion { get; set; }
        }
    }
