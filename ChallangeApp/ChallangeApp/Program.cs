using ChallangeApp;

var employee1 = new Employee("Paweł", "Zduński", 25);
var employee2 = new Employee("Andrzej", "Budzyński", 38);
var employee3 = new Employee("Lucjan", "Mostowiak", 45);

employee1.AddRating(5);
employee1.AddRating(4);
employee1.AddRating(8);
employee1.AddRating(2);
employee1.AddRating(3);

employee2.AddRating(5);
employee2.AddRating(4);
employee2.AddRating(8);
employee2.AddRating(3);
employee2.AddRating(3);

employee3.AddRating(2);
employee3.AddRating(3);
employee3.AddRating(5);
employee3.AddRating(4);
employee3.AddRating(3);

List<Employee> company = new List<Employee>()
{
    employee1, employee2, employee3
};


int maxRating = -1;
List<Employee> bestEmployees = new List<Employee>();


foreach (var employee in company)
{
    if (employee.TotalRating > maxRating)
    {
        maxRating = employee.TotalRating;
        bestEmployees.Clear();
        bestEmployees.Add(employee);
    }
    else if (employee.TotalRating == maxRating)
    {
        maxRating = employee.TotalRating;
        bestEmployees.Add(employee);
    }
}

if (bestEmployees.Count > 1)
{
    Console.WriteLine("Najwyższą ocenę zdobyli: ");
    foreach (var bestEmployee in bestEmployees)
    {
        Console.WriteLine(bestEmployee.Name + " " + bestEmployee.Surname + ", lat " + bestEmployee.Age);
    }
    Console.WriteLine("Ich wynik to: " + bestEmployees[0].TotalRating);
}
else if (bestEmployees.Count == 1)
{
    Console.WriteLine("Najwyższą ocenę zdobył/a: " + bestEmployees[0].Name + " " + bestEmployees[0].Surname + ", lat " + bestEmployees[0].Age + ". Jej/jego wynik to: " + bestEmployees[0].TotalRating);
}
