namespace OopPrinciples.Animals
{ 
    internal class Worm(string name, int age, int weight, bool isPoisenous) : Animal(name, age, weight) 
    {

        public bool IsPoisenous { get; set; } = isPoisenous;

        public override void DoSound()
        {
            Console.WriteLine("Worm makes no sound.");
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
