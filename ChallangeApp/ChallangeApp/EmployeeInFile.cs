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
            var statistics = new Statistics();

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

            foreach (var rating in ratings)
            {
                statistics.AddRating(rating);
            }

            return statistics;

        }
    }
}
