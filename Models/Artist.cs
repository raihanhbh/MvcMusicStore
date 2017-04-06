using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public virtual List<Album> Albums { get; set; }
    }
}