using System.Collections.Generic;

namespace CircusTrein
{
    public enum Size
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }

    public enum Diet
    {
        Herbivore = 0,
        Carnivore = 1
    }

    public class Animal
    {
        public Size Size { get; private set; }
        public Diet Diet { get; private set; }

        public Animal(Size size, Diet diet)
        {
            Size = size;
            Diet = diet;
        }

        public static List<Animal> animalCollection = new List<Animal>
        {
            new Animal(Size.Small, Diet.Carnivore),
            new Animal(Size.Medium, Diet.Carnivore),
            new Animal(Size.Big, Diet.Carnivore),
            new Animal(Size.Small, Diet.Carnivore),
            new Animal(Size.Medium, Diet.Carnivore),
            new Animal(Size.Big, Diet.Carnivore),
            new Animal(Size.Small, Diet.Herbivore),
            new Animal(Size.Medium, Diet.Herbivore),
            new Animal(Size.Big, Diet.Herbivore),
            new Animal(Size.Small, Diet.Herbivore),
            new Animal(Size.Medium, Diet.Herbivore),
            new Animal(Size.Big, Diet.Herbivore),
            new Animal(Size.Small, Diet.Carnivore),
            new Animal(Size.Medium, Diet.Carnivore),
            new Animal(Size.Big, Diet.Carnivore),
            new Animal(Size.Small, Diet.Carnivore),
            new Animal(Size.Medium, Diet.Carnivore),
            new Animal(Size.Big, Diet.Carnivore),
            new Animal(Size.Small, Diet.Herbivore),
            new Animal(Size.Medium, Diet.Herbivore),
            new Animal(Size.Big, Diet.Herbivore),
            new Animal(Size.Small, Diet.Herbivore),
            new Animal(Size.Medium, Diet.Herbivore),
            new Animal(Size.Big, Diet.Herbivore)
        };

        public override string ToString()
        {
            return Size + " " + Diet;
        }
    }
}

