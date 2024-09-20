namespace OopPrinciples.People
{

    internal class PersonHandler
    {
        //3.1 - 2nd part
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        //3.1 - 3rd part
        public Person CreatePerson(int age, string fname,
            string lname, double height, double weight)
        {
            return new Person() { FName = fname, LName = lname, Age = age, Height = height, Weight = weight };
        }

        //3.1 - 4th part
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
