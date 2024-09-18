namespace OopPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new() { FName = "Anna", LName = "Johnsson"};
            PersonHandler handler = new PersonHandler();
            try
            {
                p.FName = "Lalala";
                handler.SetAge(p, 10);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(p.Age);
        }
    }
}
