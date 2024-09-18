
namespace OopPrinciples
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname,
            string lname, double height, double weight)
        {
            return new Person() { FName = fname, LName = lname, Age = age, Height = height, Weight = weight };
        }

        public void ChangeLastname(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void ChangeWeight(Person pers, double weight) 
        {
            pers.Weight = weight;
        }
    }
}
