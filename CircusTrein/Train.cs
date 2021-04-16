using System.Collections.Generic;

namespace CircusTrein
{
    public class Train
    {
        public List<Wagon> Wagons { get; set; } = new List<Wagon>();

        public List<Wagon> GetAllWagons() => Wagons;

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
            foreach (Animal animal in animalCollection)
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
