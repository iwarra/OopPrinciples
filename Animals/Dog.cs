namespace OopPrinciples.Animals
{
    internal class Dog(string name, int age, int weight, string breed) : Animal(name, age, weight)
    {
        public string Breed { get; set; } = breed;

        public override void DoSound()
        {
            Console.WriteLine("Woof, woof");
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }

        public string DogDo()
        {
            return "A dog barks, plays, cuddles and goes for walks.";
        }
    }
}
