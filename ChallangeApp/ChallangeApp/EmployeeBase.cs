namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void RatingAddedDelegate(object sender, EventArgs args);

        public abstract event RatingAddedDelegate RatingAdded;

        public EmployeeBase(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }


        public abstract void AddRating(float number);

        public abstract void AddRating(string number);

        public abstract void AddRating(char number);

        public abstract void AddRating(double number);

        public abstract void AddRating(int number);

        public abstract void AddRating(long number);

        public abstract Statistics GetStatistics();

    }
}
