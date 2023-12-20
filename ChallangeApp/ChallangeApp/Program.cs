using ChallangeApp;

Console.WriteLine("=== WELCOME TO THE EMPLOYEE EVALUATION PROGRAM ===");
Console.WriteLine("==================================================");
Console.WriteLine(" ");

var supervisor = new Supervisor("Paweł","Zduński", 'M');

Console.WriteLine("Enter the employee's rating:");

while (true)
{
    var input = Console.ReadLine();
    if (input == "X" || input == "x")
    {
        break;
    }

    try
    {
        supervisor.AddRating(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd : {ex.Message}");
    }

    Console.WriteLine("Enter next rating or end the entry by pressing 'X'");
}

var statistics = supervisor.GetStatistics();

Console.WriteLine(" ");
Console.WriteLine($"Statistics for {supervisor.Name} {supervisor.Surname}");
Console.WriteLine($"There are {statistics.Counter} correct ratings given");
Console.WriteLine($"Minimal value: {statistics.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics.Max:0.00}");
Console.WriteLine($"Average value: {statistics.Average:N3}({statistics.AverageString})");