namespace ChallangeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Counter { get; private set; }

        public float Average 
        { 
            get
            {
                return this.Sum / this.Counter;
            } 
        }

        public char AverageString 
        { 
            get
            {
                switch (this.Average)
                {
                    case var avg when avg >= 95:
                        return 'A';
                    case var avg when avg >= 80:
                        return 'B';
                    case var avg when avg >= 65:
                        return 'C';
                    case var avg when avg >= 50:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Counter = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddRating(float rating)
        {
            this.Counter ++;
            this.Sum += rating;
            this.Min = Math.Min(this.Min, rating);
            this.Max = Math.Max(this.Max, rating);
        }
    }
}
