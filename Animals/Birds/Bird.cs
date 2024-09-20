using System.Reflection;

namespace OopPrinciples.Animals.Birds
{
    //If all birds need a new attribute we add it in the Bird class
    internal class Bird(string name, int age, int weight, int wingSpan) : Animal(name, age, weight)
    {
        public int WingSpan { get; set; } = wingSpan;
        public override void DoSound()
        {
            Console.WriteLine("Cuckoo");
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
