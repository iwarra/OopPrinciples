namespace OopPrinciples.Animals
{
    internal class Horse(string name, int age, int weight, bool isRidable) : Animal(name, age, weight)
    {
        public bool IsRidable { get; set; } = isRidable;  
        
        public override void DoSound()
        {
            Console.WriteLine("Brrrrr");
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
