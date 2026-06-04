using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_AnimalSpecies2
{
    internal class AnimalFactory
    {
        public static Animal CreateAnimal(string line)
        {
            string[] parts = line.Split(',');
            string species = parts[0];
            int legs = int.Parse(parts[1]);
            string classification = parts[2];
            bool isExtinct = bool.Parse(parts[3]);
            return new Animal(species, legs, classification,isExtinct);
        }
    }
}
