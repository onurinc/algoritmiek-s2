using System.Collections.Generic;
using System.Dynamic;

namespace CircusTrein
{
    public class Train
    {
        public List<Animal> WagonWithAnimals { get; set; }
        public static List<Wagon> Wagons { get; set; } = new List<Wagon>();
        public List<Wagon> GetAllWagons() => Wagons;

        public static int WagonCount = Wagons.Count;

        bool CheckScenarios_And_CheckIfWagonFull(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.CheckAllScenarios(animal))
                {
                    return true;
                }
            }
            return false;
        }

        public void PutAnimalsInWagons(List<Animal> animalCollection)
        {
            foreach (Animal animal in GenerateAnimal.AnimalCollection)
            {
                if (!CheckScenarios_And_CheckIfWagonFull(animal))
                {
                    Wagon wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.CheckAllScenarios(animal);
                }
            }
        }
    }
}
