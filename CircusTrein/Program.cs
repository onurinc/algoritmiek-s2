using System;
using System.Collections.Generic;
using CircusTrein;

namespace Circustrein
{
    class Program
    {
        static void Main()
        {
            Train train = new Train();
            train.PutAnimalsInWagons(GenerateAnimal.AnimalCollection);
            foreach (Wagon wagon in train.GetAllWagons())
            {
                Console.Write("\n\nWagon Size: " + wagon.CurrentSize + "\nAnimals: ");
                foreach (Animal animal in wagon.GetAnimalsInWagon())
                {
                    Console.Write(animal+ ", ");
                }
            }
            Console.ReadKey();
        }
    }
}