using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MyMusic.Core.Models
{
    public class Artist
    {
        public Artist()
        {
            Musics = new Collection<Music>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; }
    }
}