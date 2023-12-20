namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> evaluation = new List<float>();

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

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
            number = number.ToUpper();
            if (number == "A" || number == "B" || number == "C" || number == "D" || number == "E")
            {
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
                }
            }
            else if (!(number == "A" || number == "B" || number == "C" || number == "D" || number == "E"))
            {
                switch (number)
                {
                    case "6":
                        this.AddRating(100);
                        break;
                    case "6-":
                    case "-6":
                        this.AddRating(95);
                        break;
                    case "5+":
                    case "+5":
                        this.AddRating(85);
                        break;
                    case "5":
                        this.AddRating(80);
                        break;
                    case "5-":
                    case "-5":
                        this.AddRating(75);
                        break;
                    case "4+":
                    case "+4":
                        this.AddRating(65);
                        break;
                    case "4":
                        this.AddRating(60);
                        break;
                    case "4-":
                    case "-4":
                        this.AddRating(55);
                        break;
                    case "3+":
                    case "+3":
                        this.AddRating(45);
                        break;
                    case "3":
                        this.AddRating(40);
                        break;
                    case "3-":
                    case "-3":
                        this.AddRating(35);
                        break;
                    case "2+":
                    case "+2":
                        this.AddRating(25);
                        break;
                    case "2":
                        this.AddRating(20);
                        break;
                    case "2-":
                    case "-2":
                        this.AddRating(15);
                        break;
                    case "1+":
                    case "+1":
                        this.AddRating(5);
                        break;
                    case "1":
                        this.AddRating(0);
                        break;
                    default:
                        if (float.TryParse(number, out float rating))
                        {
                            this.AddRating(rating);
                        }
                        else
                        {
                            throw new Exception($"Unknown rating: {number}");
                        }
                        break;
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