using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Wagon
    {
        public List<Animal> WagonWithAnimals { get; set; } = new List<Animal>();

        public int Size { get; private set; } = 10;

        public int CurrentSize => WagonWithAnimals.Sum(a => (int)a.Size);

        public List<Animal> GetAnimalsInWagon() => WagonWithAnimals;

        bool CheckIfCarnivoreIsBiggerThan_Or_EqualToOtherAnimal(Animal AnimalToAdd)
        {
            foreach (Animal animal in WagonWithAnimals)
            {
                if (AnimalToAdd.Diet == Diet.Carnivore && AnimalToAdd.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckIfHerbivoreIsSmallerThan_Or_EqualToCarnivore(Animal animalToCompare)
        {
            foreach (Animal animal in WagonWithAnimals)
            {
                if (animalToCompare.Diet == Diet.Herbivore && animal.Diet == Diet.Carnivore && animalToCompare.Size <= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckIfThereIsTwoCarnivores(Animal animalToCompare)
        {
            foreach (Animal animal in WagonWithAnimals)
            {
                if (animalToCompare.Diet == Diet.Carnivore && animal.Diet == Diet.Carnivore)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckAllScenarios(Animal animalToAdd)
        {
            if (CheckIfCarnivoreIsBiggerThan_Or_EqualToOtherAnimal(animalToAdd) && CheckIfHerbivoreIsSmallerThan_Or_EqualToCarnivore(animalToAdd) && (int)animalToAdd.Size + CurrentSize <= Size && CheckIfThereIsTwoCarnivores(animalToAdd))
            {
                WagonWithAnimals.Add(animalToAdd);
                return true;
            }
            return false;
        }
    }
}
