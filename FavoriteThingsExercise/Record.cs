using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThingsExercise
{
    internal class Record
    {
        public string Artist { get; set; }

        public string Title { get; set; }

        public Record(string artist, string title)
        {
            Artist = artist;
            Title = title;
        }

        public void FavRecord()
        {
            Console.WriteLine($"Lets listen to {Title} by {Artist}");
        }
    }
}
