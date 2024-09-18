
namespace OopPrinciples
{
    //If all animals need a new attribute we add it in the Animal class
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public abstract void DoSound();

        public Animal(string name, int age, int weight) 
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

    internal class Dog : Animal
    {
        public Dog(string name, int age, int weight, string kind) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof, woof");
        }
    }

    internal class Horse : Animal
    {
        public Horse(string name, int age, int weight, bool isRidable) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Brrrrr");
        }
    }

    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, int age, int weight, string habitat) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Cccccc"); ;
        }
    }

    internal class Worm : Animal
    {
        public Worm(string name, int age, int weight, bool isPoisenous) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm makes no sound.");
        }
    }

    //If all birds need a new attribute we add it in the Bird class
    internal class Bird : Animal
    {
        public Bird(string name, int age, int weight, string wingSpan) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Cuckoo");
        }
    }

    internal class Wolf : Animal
    {
        public Wolf(string name, int age, int weight, string faveFood) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Auuuuu");
        }
    }

    internal class Pelican : Bird
    {
        public Pelican(string name, int age, int weight, string wingSpan, int beakSize) : base(name, age, weight, wingSpan)
        {
        }
    }

    internal class Flamingo : Bird
    {
        public Flamingo(string name, int age, int weight, string wingSpan, int height) : base(name, age, weight, wingSpan)
        {
        }
    }

    internal class Swan : Bird
    {
        public Swan(string name, int age, int weight, string wingSpan, bool isViolent) : base(name, age, weight, wingSpan)
        {
        }
    }
}
