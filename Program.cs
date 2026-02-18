using System;
namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Dog : Animal
    {
        public override string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        
        public Dog()
        {
            Name = "Unknown";
            Breed = "Unknown";
            Age = 0;
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public override string Describe()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Console.WriteLine(dog1.Describe());
            Console.WriteLine(dog1.whatAmI());

            Dog dog2 = new Dog("Alice", "Pitbull", 8);
            Console.WriteLine(dog2.Describe());
            Console.WriteLine(dog2.whatAmI());
        }
    }
}

