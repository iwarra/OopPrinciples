using System.Reflection;

namespace OopPrinciples.Animals.Birds
{
    internal class Swan(string name, int age, int weight, int wingSpan, bool isViolent) : Bird(name, age, weight, wingSpan)
    {
        public bool IsViolent { get; set; } = isViolent;

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
