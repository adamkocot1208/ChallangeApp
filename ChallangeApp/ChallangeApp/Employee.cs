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
                throw new Exception("Invalid rating value");
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
                switch(number)
                {
                    case "A":
                    case "a":
                        this.AddRating(100);
                        break;
                    case "B":
                    case "b":
                        this.AddRating(80);
                        break;
                    case "C":
                    case "c":
                        this.AddRating(60);
                        break;
                    case "D":
                    case "d":
                        this.AddRating(40);
                        break;
                    case "E":
                    case "e":
                        this.AddRating(20);
                        break;
                    default:
                        throw new Exception($"Unknown number: {number}");
                }
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
            statistics.Counter = 0;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var rating in this.evaluation)
            {
                statistics.Max = Math.Max(statistics.Max, rating);
                statistics.Min = Math.Min(statistics.Min, rating);
                statistics.Counter += 1;
                statistics.Average += rating;
            }

            statistics.Average /= this.evaluation.Count;

            switch (statistics.Average)
            {
                case var avg when avg >= 95:
                    statistics.AverageString = 'A';
                    break;
                case var avg when avg >= 80:
                    statistics.AverageString = 'B';
                    break;
                case var avg when avg >= 65:
                    statistics.AverageString = 'C';
                    break;
                case var avg when avg >= 50:
                    statistics.AverageString = 'D';
                    break;
                default:
                    statistics.AverageString = 'E';
                    break;
            }

            return statistics;
        }

    }
}
