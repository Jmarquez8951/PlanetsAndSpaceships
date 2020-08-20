using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main()
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine(string.Join(", ", rockyPlanets));

            planetList.Remove("Pluto");
        }
    }
}
