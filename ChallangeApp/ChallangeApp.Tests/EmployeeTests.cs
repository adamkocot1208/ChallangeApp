namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TwoEmployeesNotEqual()
        {
            var emp1 = GetEmployee("Pawe³", "Zduñski", 'M');
            var emp2 = GetEmployee("Pawe³", "Zduñski", 'M');

            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void NameOfTwoEmployeesEqual()
        {
            var emp1 = GetEmployee("Pawe³", "Zduñski", 'M');
            var emp2 = GetEmployee("Pawe³", "Zduñski", 'M');

            Assert.AreEqual(emp1.Name, emp2.Name);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectAverageRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 'M');
            employee.AddRating(20);
            employee.AddRating(25);
            employee.AddRating(55);
            employee.AddRating('A');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(50, statistics.Average);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectMaxRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 'M');
            employee.AddRating(6.24f);
            employee.AddRating(7);
            employee.AddRating(1.23f);
            employee.AddRating('A');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void EmployeeCollectRatings_ShouldCorrectMinRating()
        {
            var employee = new Employee("Pawe³", "Zduñski", 'M');
            employee.AddRating(62.4f);
            employee.AddRating(70);
            employee.AddRating(31.23f);
            employee.AddRating('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }

        private Employee GetEmployee(string name, string surname, char sex)
        {
            return new Employee(name, surname, sex);
        }
    }
}