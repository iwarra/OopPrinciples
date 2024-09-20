using OopPrinciples.Animals;
using OopPrinciples.Animals.Birds;
using OopPrinciples.Errors;
using OopPrinciples.People;

namespace OopPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1 - 1st part
            /*
            Person p = new() { FName = "Anna", LName = "Johnsson"};
            p.Age = 29;
            //We can access the values; the ones not yet defined give 0;
            Console.WriteLine($"{p.FName} is {p.Age} years old.");
            
            try
            {
                p.Age = -5;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            */
            
            //3.1 - 5th part
            PersonHandler handler = new PersonHandler();
            Person p1 = handler.CreatePerson(25, "Sara", "Nilsson", 167, 56);
            Person p2 = handler.CreatePerson(60, "Max", "Ying", 190, 95);
            Person me = handler.CreatePerson(35, "Ivona", "Josipovic", 183, 66);
            try
            {
                p1.FName = "";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            List<Person> people = new List<Person>
            {
                p1,
                p2,
                me
            };

            foreach (Person person in people) 
            {
                Console.WriteLine($"{person.FName} {person.LName} is {person.Height} cm tall.");
            }

            Console.WriteLine("\n - - - - - \n"); //spacing between

            //3.2 
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();   
            EmptyInputError emptyInputError = new EmptyInputError();
            UnchangeableInputError unchangeableInputError = new UnchangeableInputError();
            TestInputError testInputError = new TestInputError();

            List<UserError> userErrors = new List<UserError> 
            {
                numericInputError,
                textInputError,
                emptyInputError,
                unchangeableInputError,
                testInputError
            };

            foreach (UserError userError in userErrors) 
            {
               Console.WriteLine(userError.UEMessage());
            }

            Console.WriteLine("\n - - - - - \n"); //spacing between

            //3.3 - using a simplified new syntax here
            Wolfman w = new("w", 4, 60, "humans");
            w.Talk();

            Console.WriteLine("\n - - - - - \n"); //spacing between

            //3.4
            Dog d = new("Nikki", 6, 10, "Shiba inu");
            Dog d2 = new("Phoebe", 2, 8, "Cocker spaniel");
            Horse h = new("Horsy", 3, 70, true);
            Wolf wolf = new("Wolfy", 8, 30, "chicken");
            Flamingo f = new("Pinky", 5, 5, 58, 106);

            List<Animal> animals = new List<Animal>
            {
                d,
                d2,
                h,
                wolf,
                f
            };

            foreach (Animal animal in animals)
            {
                Console.Write($"{animal.Name} says: ");
                animal.DoSound();
            }


            //3.4 - point 7
            foreach (Animal animal in animals)
            {
                //Doing a check and type casting in the conditional
                if (animal.GetType() != typeof(Dog) && animal is IPerson mutant)
                {
                    mutant.Talk();
                }
            }

            Console.WriteLine("\n - - - - - \n"); //spacing between

            //3.4 - point 8
            List<Dog> dogs = new List<Dog>
            {
                d, 
                d2,
               // h - hourse can't be added because it's not of type Dog
               //list would need to be of type Animal for all animals to be added in it
            };


            //3.4 - point 11
            Console.WriteLine("All animal stats: ");
            foreach (var animal in animals)
            {
                //Console.WriteLine(animal.GetType());
                 Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("\n - - - - - \n"); //spacing between

            // 3.4 - point 14
            Console.WriteLine("Dog stats only: ");
            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    Console.WriteLine(animal.Stats());
                    // the method I created for point 15 is not accessible here: animal.DogDo()
                    // It's because Dog inherits from animal, not the other way around 
                }
                    // We can make it work by type casting
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.DogDo());
                }
            }

        }
    }
}
