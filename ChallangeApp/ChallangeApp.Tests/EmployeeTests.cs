namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeCollectOnlyPositiveRatings_ShouldCorrectTotalRating()
        {

            var employee = new Employee("Pawe³", "Zduñski", 25);
            employee.AddRating(7);
            employee.AddRating(3);
            employee.AddRating(8);

            var result = employee.TotalRating;

            Assert.AreEqual(18, result);
        }

        [Test]
        public void EmployeeCollectOnlyNegativeRatings_ShouldCorrectTotalRating()
        {
           
            var employee = new Employee("Pawe³", "Zduñski", 25);
            employee.AddRating(-7);
            employee.AddRating(-3);
            employee.AddRating(-5);

            var result = employee.TotalRating;

            Assert.AreEqual(-15, result);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectTotalRating()
        {
     
            var employee = new Employee("Pawe³", "Zduñski", 25);
            employee.AddRating(9);
            employee.AddRating(4);
            employee.AddRating(-7);

            var result = employee.TotalRating;

            Assert.AreEqual(6, result);
        }
    }
}