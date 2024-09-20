namespace OopPrinciples.Animals.Birds
{
    internal class Flamingo(string name, int age, int weight, int wingSpan, int height) : Bird(name, age, weight, wingSpan)
    {
        public int Height {
            get 
            { 
                return height; 
            }
            set 
            { 
                height = value; 
            }
        }

        public override string Stats()
        {
            var baseStats = base.Stats();

            return $"{baseStats}";
        }
    }
}
