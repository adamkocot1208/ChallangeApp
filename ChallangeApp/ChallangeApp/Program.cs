using ChallangeApp;

var employee1 = new Employee("Paweł", "Zduński", 19);

employee1.AddRating("Adam");
employee1.AddRating("2023");
employee1.AddRating("Adam2023"[3]);
employee1.AddRating(3.5);
employee1.AddRating(2);
employee1.AddRating(5);

var statistics = employee1.GetStatistics();

Console.WriteLine(" ");
Console.WriteLine($"There are {statistics.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics.Max:0.00}");
Console.WriteLine($"Average value: {statistics.Average:N3}");
