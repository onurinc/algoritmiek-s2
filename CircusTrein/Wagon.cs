using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Wagon
    {
        public int WagonSize { get; private set; } = 10;
        public List<Animal> AnimalInWagon { get; set; } = new List<Animal>();
        public int CurrentSize => AnimalInWagon.Sum(a => (int)a.Size);
        public List<Animal> GetAnimalsInWagon() => AnimalInWagon;



        public bool zzCheckAllScenarios(Animal animalToAdd)
        {
            foreach (Animal animal in AnimalInWagon)
            {
                if (!(animalToAdd.Diet == Enums.Diet.Carnivore && animal.Diet == Enums.Diet.Carnivore) &&
                    !(animalToAdd.Diet == Enums.Diet.Herbivore && animal.Diet == Enums.Diet.Carnivore && animalToAdd.Size <= animal.Size) &&
                    !(animalToAdd.Diet == Enums.Diet.Carnivore && animalToAdd.Size >= animal.Size) &&
                    ((int)animalToAdd.Size + CurrentSize <= WagonSize))
                {
                    AnimalInWagon.Add(animalToAdd);
                    return true;
                }
            }
            return false;
        }

        
        public bool CheckIfCarnivoreIsBiggerThan_Or_EqualToOtherAnimal(Animal animalToAdd)
        {
            foreach (Animal animal in AnimalInWagon)
            {
                if (animalToAdd.Diet == Enums.Diet.Carnivore && animalToAdd.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfHerbivoreIsSmallerThan_Or_EqualToCarnivore(Animal animalToAdd)
        {
            foreach (Animal animal in AnimalInWagon)
            {
                if (animalToAdd.Diet == Enums.Diet.Herbivore && animal.Diet == Enums.Diet.Carnivore && animalToAdd.Size <= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfThereIsTwoCarnivoresV2(Animal animalToAdd)
        {
            if (AnimalInWagon.Any(a => a.Diet == Enums.Diet.Carnivore && animalToAdd.Diet == Enums.Diet.Carnivore))
            {
                return false;
            }
            return true;
        }

        public bool CheckIfThereIsTwoCarnivores(Animal animalToAdd)
        {
            foreach (Animal animal in AnimalInWagon)
            {
                if (animalToAdd.Diet == Enums.Diet.Carnivore && animal.Diet == Enums.Diet.Carnivore)
                {
                    return false;
                }
            }
            return true;
        }


        public bool CheckAllScenarios(Animal animalToAdd)
        {
            if (CheckIfCarnivoreIsBiggerThan_Or_EqualToOtherAnimal(animalToAdd) && 
                CheckIfHerbivoreIsSmallerThan_Or_EqualToCarnivore(animalToAdd) &&
                CheckIfThereIsTwoCarnivores(animalToAdd) &&
                (int)animalToAdd.Size + CurrentSize <= WagonSize)
            {
                AnimalInWagon.Add(animalToAdd);
                return true;
            }
            return false;
        }
    }
}
