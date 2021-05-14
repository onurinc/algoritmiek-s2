using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Animal
    {
        public Enums.Size Size { get; private set; }
        public Enums.Diet Diet { get; private set; }
        public List<Animal> AnimalCollection { get;  set; }

        public Animal(Enums.Size size, Enums.Diet diet)
        {
            Size = size;
            Diet = diet;
        }

        public override string ToString()
        {
            return Size + " " + Diet;
        }
    }
}

