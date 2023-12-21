namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "ratings.txt";

        public override event RatingAddedDelegate RatingAdded;

        public EmployeeInFile(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }

        public override void AddRating(float number)
        {
            if (number >= 0 && number <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(number);
                }

                if (RatingAdded != null)
                {
                    RatingAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid rating value");
            }

        }

        public override void AddRating(string number)
        {
            if (float.TryParse(number, out float rating))
            {
                this.AddRating(rating);
            }
            else
            {
                number = number.ToUpper();
                switch (number)
                {
                    case "A":
                        this.AddRating(100);
                        break;
                    case "B":
                        this.AddRating(80);
                        break;
                    case "C":
                        this.AddRating(60);
                        break;
                    case "D":
                        this.AddRating(40);
                        break;
                    case "E":
                        this.AddRating(20);
                        break;
                    default:
                        throw new Exception($"Unknown number: {number}");
                }
            }
        }

        public override void AddRating(char number)
        {
            string rating = number.ToString();
            this.AddRating(rating);
        }

        public override void AddRating(double number)
        {
            float rating = (float)number;
            this.AddRating(rating);
        }

        public override void AddRating(int number)
        {
            float rating = (float)number;
            this.AddRating(rating);
        }

        public override void AddRating(long number)
        {
            float rating = (float)number;
            this.AddRating(rating);
        }

        public override Statistics GetStatistics()
        {
            var ratings = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        ratings.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }

            var statistics = new Statistics();
            statistics.Counter = 0;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var rating in ratings)
            {
                statistics.Max = Math.Max(statistics.Max, rating);
                statistics.Min = Math.Min(statistics.Min, rating);
                statistics.Counter += 1;
                statistics.Average += rating;
            }

            statistics.Average /= ratings.Count;

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
