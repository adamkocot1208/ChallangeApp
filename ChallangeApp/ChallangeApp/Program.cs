using ChallangeApp;

var employee1 = new Employee("Paweł", "Zduński", 19);

employee1.AddRating(3.5);
employee1.AddRating(2);
employee1.AddRating(5);
employee1.AddRating(4);
employee1.AddRating(1);

var statistics1 = employee1.GetStatistics();
var statistics2 = employee1.GetStatisticsWithForEach();
var statistics3 = employee1.GetStatisticsWithFor();
var statistics4 = employee1.GetStatisticsWithDoWhile();
var statistics5 = employee1.GetStatisticsWithWhile();

Console.WriteLine(" ");
Console.WriteLine("Result of GetStatistics() method");
Console.WriteLine($"There are {statistics1.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics1.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics1.Max:0.00}");
Console.WriteLine($"Average value: {statistics1.Average:N3}");

Console.WriteLine(" ");
Console.WriteLine("Result of GetStatisticsWithForEach() method");
Console.WriteLine($"There are {statistics2.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics2.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics2.Max:0.00}");
Console.WriteLine($"Average value: {statistics2.Average:N3}");

Console.WriteLine(" ");
Console.WriteLine("Result of GetStatisticsWithFor() method");
Console.WriteLine($"There are {statistics3.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics3.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics3.Max:0.00}");
Console.WriteLine($"Average value: {statistics3.Average:N3}");

Console.WriteLine(" ");
Console.WriteLine("Result of GetStatisticsWithDoWhile() method");
Console.WriteLine($"There are {statistics4.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics4.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics4.Max:0.00}");
Console.WriteLine($"Average value: {statistics4.Average:N3}");

Console.WriteLine(" ");
Console.WriteLine("Result of GetStatisticsWithWhile() method");
Console.WriteLine($"There are {statistics5.Counter} correct numbers given");
Console.WriteLine($"Minimal value: {statistics5.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics5.Max:0.00}");
Console.WriteLine($"Average value: {statistics5.Average:N3}");