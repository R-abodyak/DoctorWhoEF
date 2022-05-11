using System;
using System. Collections. Generic;
using System. Text;

namespace DoctorWho. DB. Models
    {
    public class Doctor
        {
        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }

        public string DoctorName { get; set; }
        DateTime BirthDate { get; set; }

        DateTime FirstEpisodeDate { get; set; }
        DateTime LastEpisodeDate { get; set; }

        //
        public ICollection<Episode> Episodes { get; set; }

        }
    }
