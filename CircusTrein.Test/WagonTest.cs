using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Linq.Expressions;


namespace CircusTrein.Test
{
    [TestClass]
    public class WagonTest
    {
        List<Animal> _wagon = new List<Animal>();
        public int WagonSize = 10;
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void Wagon_Empty_Check()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsNotNull(_wagon);
            Assert.AreEqual(0, _wagon.Sum(a => (int)a.Size));
        }

        [TestMethod]
        public void When_Animal_Is_Added_Capacity_Is_Same_As_Animal()
        {
            //Arrange
            Animal animal = new Animal(Enums.Size.Big, Enums.Diet.Herbivore);
            int originalCapacity = 10;
            int animalSize = (int)animal.Size;
            int expectedCapacity = originalCapacity - animalSize;

            //Act
            _wagon.Add(animal);

            // Assert
            Assert.AreEqual(animalSize, _wagon.Sum(a => (int)a.Size));
        }

        [TestMethod]
        public void Cant_Add_2_Carnivores_In_Same_Wagon()
        {
            var TestResult = true;
            //Arrange
            List<Animal> TestWagonOne = new List<Animal>();
            TestWagonOne.Add(new Animal(Enums.Size.Medium, Enums.Diet.Carnivore));
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Carnivore));

            //Act
            Wagon wagon = new Wagon();
            foreach (Animal animal in TestWagonOne)
            {
                TestResult = wagon.CheckAllScenarios(animal);
            }

            //Assert
            Assert.IsFalse(TestResult);
        }

        [TestMethod]
        public void Possible_To_Add_Small_Carnivore_With_Big_Herbivore()
        {
            var TestResult = false;
            //Arrange
            List<Animal> TestWagonOne = new List<Animal>();
            TestWagonOne.Add(new Animal(Enums.Size.Small, Enums.Diet.Carnivore));
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Carnivore));

            //Act
            Wagon wagon = new Wagon();
            foreach (Animal animal in TestWagonOne)
            {
                TestResult = wagon.CheckAllScenarios(animal);
            }

            //Assert
            Assert.IsFalse(TestResult);
        }

        [TestMethod]
        public void Cant_Add_Herbivore_With_Or_Bigger_Carnivore()
        {
            var TestResult = true;
            //Arrange
            List<Animal> TestWagonOne = new List<Animal>();
            TestWagonOne.Add(new Animal(Enums.Size.Medium, Enums.Diet.Herbivore));
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Carnivore));

            //Act
            Wagon wagon = new Wagon();
            foreach (Animal animal in TestWagonOne)
            {
                TestResult = wagon.CheckAllScenarios(animal);
            }

            //Assert
            Assert.IsFalse(TestResult);
        }

        [TestMethod]
        public void Cant_Add_Animal_If_Size_Exceeds()
        {
            var TestResult = true;
            //Arrange
            List<Animal> TestWagonOne = new List<Animal>();
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Herbivore));
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Herbivore));
            TestWagonOne.Add(new Animal(Enums.Size.Big, Enums.Diet.Herbivore));

            //Act
            Wagon wagon = new Wagon();
            foreach (Animal animal in TestWagonOne)
            {
                TestResult = wagon.CheckAllScenarios(animal);
            }

            //Assert
            Assert.IsFalse(TestResult);
        }
    }
}
