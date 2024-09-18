
namespace OopPrinciples
{
    internal interface IPerson
    {
        void Talk();
    }
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //ToDo: Create a constructor with checks implemeted to get valid input

        public int Age { get { return age; }
            set
            {
                if (value < 0) throw new ArgumentException("Please provide a valid age.");
                else age = value;
            }
        }
        public required string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length > 10 && value.Length < 2) throw new ArgumentException("Please provide a valid first name.");
                else fName = value;
            }
        }
        public required string LName { get { return lName; }
            set
            {
                if (value.Length > 15 && value.Length < 3) throw new ArgumentException("Please provide a valid last name.");
                else lName = value;
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

    }

    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, int weight, string faveFood) : base(name, age, weight, faveFood)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am going to eat ya!");
        }
    }
}
