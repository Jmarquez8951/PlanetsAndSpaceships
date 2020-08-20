using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.Write("Rocky Planets: ");
            Console.Write(string.Join(", ", rockyPlanets));
            Console.WriteLine("");

            planetList.Remove("Pluto");

            var spaceProbes = new Dictionary<string, List<string>>
            {
                {
                    "Voyager 1", new List<string>
                    {
                        "Earth",
                        "Jupiter",
                        "Saturn",
                    }
                },
                {
                    "Voyager 2", new List<string>
                    {
                        "Earth",
                        "Jupiter",
                        "Saturn",
                        "Uranus",
                        "Neptune"
                    }
                },
                {
                    "Mariner 3", new List<string> 
                    {
                        "Earth",
                        "Saturn",
                        "Jupiter",
                        "Uranus"
                    }
                },
                {
                     "Mariner 10", new List<string>
                     {
                         "Earth",
                         "Neptune",
                         "Venus",
                         "Pluto"
                     }
                }
            };

            foreach (var planet in planetList)
            {
                var probes = spaceProbes
                    .Where(probe => probe.Value.Contains(planet))
                    .Select(probe => probe.Key);

                Console.WriteLine($"{planet}: {string.Join(", ", probes)}");
            }
            
        }
    }
}
