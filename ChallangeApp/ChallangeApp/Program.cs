using ChallangeApp;

var employee1 = new Employee("Paweł", "Zduński", 19);

Console.Write("Proszę podać ile ocen otrzymał dany pracownik: ");
var numberString = Console.ReadLine();
var success = int.TryParse(numberString, out var numberOfRatings);

for (int i = 0; i< numberOfRatings; i++)
{
    Console.Write($"Proszę wpisać {i+1}. ocenę: ");
}

var statistics = employee1.GetStatistics();
Console.WriteLine($"Minimal value: {statistics.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics.Max:0.00}");
Console.WriteLine($"Average value: {statistics.Average:N3}");
