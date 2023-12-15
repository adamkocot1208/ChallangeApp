namespace ChallangeApp
{
    public class Employee
    {
        private List<float> evaluation = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddRating(float number)
        {
            this.evaluation.Add(number);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var rating in this.evaluation)
            {
                statistics.Max = Math.Max(statistics.Max, rating);
                statistics.Min = Math.Min(statistics.Min, rating);
                statistics.Average += rating;
            }

            statistics.Average /= this.evaluation.Count;

            return statistics;
        }

    }
}
