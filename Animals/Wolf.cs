using System.Reflection;

namespace OopPrinciples.Animals
{
    internal class Wolf(string name, int age, int weight, string faveFood) : Animal(name, age, weight)
    {
        public string FavFood { get; set; } = faveFood;
        public override void DoSound()
        {
            Console.WriteLine("Auuuuu");
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }

}
