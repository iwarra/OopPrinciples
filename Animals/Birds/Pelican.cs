using System.Reflection;

namespace OopPrinciples.Animals.Birds
{
    internal class Pelican(string name, int age, int weight, int wingSpan, int beakSize) : Bird(name, age, weight, wingSpan)
    {
        public int BeakSize { get; set; } = beakSize;

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
