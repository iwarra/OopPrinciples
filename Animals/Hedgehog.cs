using System.Reflection;

namespace OopPrinciples.Animals
{
    internal class Hedgehog(string name, int age, int weight, string habitat) : Animal(name, age, weight)
    {
        public string Habitat { get; set; } = habitat;

        public override void DoSound()
        {
            Console.WriteLine("Cccccc"); ;
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
