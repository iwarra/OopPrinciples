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

            //3.3
            Wolfman w = new Wolfman("w", 4, 60, "humans");
            w.Talk();
        }
    }
}
