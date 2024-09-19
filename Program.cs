namespace OopPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1 part
            Person p = new() { FName = "Anna", LName = "Johnsson"};
            PersonHandler handler = new PersonHandler();
            try
            {
                p.FName = "Lalala";
                handler.SetAge(p, 10);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Person me = handler.CreatePerson(35, "Ivona", "Josipovic", 183, 66);
            Console.WriteLine(me.FName);

            //3.2 part
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();   
            EmptyInputError emptyInputError = new EmptyInputError();
            UnchangeableInputError unchangeableInputError = new UnchangeableInputError();
            TestInputError testInputError = new TestInputError();

            List<UserError> UserErrors = new List<UserError> 
            {
                numericInputError,
                textInputError,
                emptyInputError,
                unchangeableInputError,
                testInputError
            };

            foreach (UserError userError in UserErrors) 
            {
                Console.WriteLine(userError.UEMessage());
            }

            //3.3 - using a simplified new syntax here
            Wolfman w = new("w", 4, 60, "humans");
            w.Talk();

            //3.4
            Dog d = new("Nikki", 6, 10, "shiba inu");
            Horse h = new("Horsy", 3, 70, true);
            Wolf wolf = new("Wolfy", 8, 30, "chicken");

            List<Animal> animals = new List<Animal>
            {
                d,
                h,
                wolf
            };

            foreach (var animal in animals)
            {
                Console.Write($"{animal.Name} says: ");
                animal.DoSound();
            }


        }
    }
}
