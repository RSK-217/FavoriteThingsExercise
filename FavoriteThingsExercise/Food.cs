using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThingsExercise
{
    internal class Food
    {

        public Food(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public void FavFood()
        {
            Console.WriteLine($"Lets order a {Description} {Name} tonight.");
        }
    }

}
