namespace OopPrinciples.People
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //ToDo: Create a constructor with checks implemeted to get valid input

        public int Age
        {
            get
            {
                return age;
            }
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
                if (value.Length > 10 || value.Length < 2) throw new ArgumentException("Please provide a valid first name with minimum two and maximum ten letters.");
                else fName = value;
            }
        }
        public required string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length > 15 || value.Length < 3) throw new ArgumentException("Please provide a valid last name with minimum tree and maximum 15 letters.");
                else lName = value;
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

    }
}
