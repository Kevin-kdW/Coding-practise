using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_AnimalSpecies1
{
    internal class Animal
    {
		private string species;

		public string Species
		{
			get { return species; }
			set { species = value; }
		}

		private int legs;

		public int Legs
		{
			get { return legs; }
			set { legs = value; }
		}

		private string classification;

		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}


		private bool isExtinct;

		public bool IsExtinct
		{
			get { return isExtinct; }
			set { isExtinct = value; }
		}

        public Animal(string species, int legs, string classification, bool isExtinct)
        {
			Species = species;
			Legs = legs;
			Classification = classification;
			IsExtinct = isExtinct;
        }

        public override string ToString()
        {
            if (legs == 2 && isExtinct == true)
			{
                return $"{species} ({legs}) {classification} ({isExtinct})"; 
			}
			else
			{
                return $"{species} ({legs}) {classification}";
            }
        }
    }
}
