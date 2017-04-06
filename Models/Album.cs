using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        //public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
        public string Title { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You must put a Year" )]
        [DataType(DataType.Date)]
        public string ReleaseYear { get; set; }


    
    }
}