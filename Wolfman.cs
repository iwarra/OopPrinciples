using OopPrinciples.Animals;
using OopPrinciples.People;

namespace OopPrinciples
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, int weight, string faveFood) : base(name, age, weight, faveFood)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I'm going to eat ya!");
        }
    }
}
