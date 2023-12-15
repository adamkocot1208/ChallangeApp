namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TwoEmployeesNotEqual()
        {
            var emp1 = GetEmployee("Pawe³", "Zduñski",19);
            var emp2 = GetEmployee("Pawe³", "Zduñski",19);

            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void NameOfTwoEmployeesEqual()
        {
            var emp1 = GetEmployee("Pawe³", "Zduñski", 19);
            var emp2 = GetEmployee("Pawe³", "Zduñski", 19);

            Assert.AreEqual(emp1.Name, emp2.Name);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectAverageRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 19);
            employee.AddRating(5.50f);
            employee.AddRating(4.50f);
            employee.AddRating(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Average);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectMaxRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 19);
            employee.AddRating(6.24f);
            employee.AddRating(7);
            employee.AddRating(1.23f);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(7.00f, statistics.Max);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectMinRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 19);
            employee.AddRating(6.24f);
            employee.AddRating(7);
            employee.AddRating(1.23f);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(1.23f, statistics.Min);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}