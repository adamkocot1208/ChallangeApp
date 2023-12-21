using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname {  get; }

        char Sex { get; }

        void AddRating(float number);

        void AddRating(string number);

        void AddRating(char number);

        void AddRating(double number);

        void AddRating(int number);

        void AddRating(long number);

        event RatingAddedDelegate RatingAdded;

        Statistics GetStatistics();
        
    }
}
