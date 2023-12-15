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
            if (number >= 0 && number <= 100)
            {
                this.evaluation.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid rating value");
            }
        }

        public void AddRating(string number)
        {
            if (float.TryParse(number, out float rating))
            {
                this.AddRating(rating);
            }
            else
            {
                Console.WriteLine("String is not a number value");
            }
        }

        public void AddRating(char number)
        {
            string rating = number.ToString();
            this.AddRating(rating);
        }

        public void AddRating(double number)
        {
            float rating = (float)number;
            this.AddRating(rating);
        }

        public void AddRating(int number)
        {
            float rating = (float)number;
            this.AddRating(rating);
        }

        public void AddRating(long number)
        {
            float rating = (float)number;
            this.AddRating(rating);
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
