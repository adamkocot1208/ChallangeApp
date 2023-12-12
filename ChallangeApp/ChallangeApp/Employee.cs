namespace ChallangeApp
{
    public class Employee
    {
        private List<int> evaluation = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int TotalRating
        {
            get
            {
                return this.evaluation.Sum();
            }
        }

        public void AddRating(int number)
        {
            evaluation.Add(number);
        }


    }
}
