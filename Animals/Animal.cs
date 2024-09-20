using System.Reflection;

namespace OopPrinciples.Animals
{
    //If all animals need a new attribute we add it in the Animal class
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public abstract void DoSound();

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public virtual string Stats()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Building a string with property name and value
            return string.Join(", ", properties.Select(p => $"{p.Name}: {p.GetValue(this)}"));
        }

    }  
}
