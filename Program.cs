namespace OopPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new() { FName = "Anna", LName = "Johnsson"};
            try
            {
            p.FName = "Lalala";
            p.Age = -1;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
