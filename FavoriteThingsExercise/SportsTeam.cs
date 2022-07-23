using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThingsExercise
{
    public class SportsTeam
    {
        public string Sport { get; set; }

        public string Team { get; set; }

        public SportsTeam(string sport, string team)
        {
            Sport = sport;
            Team = team;
        }

        public void FavTeam()
        {
            Console.WriteLine($"My favorite {Sport} team is the {Team}.");
        }
    }
}
