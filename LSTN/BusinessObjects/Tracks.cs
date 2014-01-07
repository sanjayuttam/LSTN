using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSTN.BusinessObjects
{
    public class Tracks
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Artist { get; set; }
        public string Track { get; set; }
        public DateTime? CreateTime { get; set; }
        public string YouTubeUrl { get; set; }
        public int? YouTubeConfidence { get; set; }
        public string SpotifyUrl { get; set; }
        public int? SpotfyConfidence { get; set; }

        public Tracks()
        {

        }
    }
}