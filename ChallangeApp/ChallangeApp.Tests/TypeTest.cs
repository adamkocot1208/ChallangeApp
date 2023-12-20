
namespace ChallangeApp.Tests
{
    internal class TypeTest
    {
        [Test]
        public void IntShouldRetrunSameObject()
        {
            int num1 = 10;
            int num2 = 10;

            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void FloatNotShouldRetrunSameObject()
        {
            float num3 = 10.89f;
            float num4 = -11.20f;

            Assert.AreNotEqual(num3, num4);
        }

        [Test]
        public void StringShouldRetrunSameObject()
        {
            string str1 = "owsianka";
            string str2 = "owsianka";

            Assert.AreEqual(str1, str2);
        }

        [Test]
        public void TwoEmployeesNotEqual()
        {
            var emp1 = GetEmployee("Paweł", "Zduński", 'M');
            var emp2 = GetEmployee("Paweł", "Kowalski", 'M');

            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void SurnameOfTwoEmployeesEqual()
        {
            var emp1 = GetEmployee("Paweł", "Zduński", 'M');
            var emp2 = GetEmployee("Paweł", "Zduński", 'M');

            Assert.AreEqual(emp1.Surname, emp2.Surname);
        }


        private Employee GetEmployee(string name, string surname, char sex)
        {
            return new Employee(name, surname, sex);
        }
    }

}
