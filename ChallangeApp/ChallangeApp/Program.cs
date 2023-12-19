﻿using ChallangeApp;

Console.WriteLine("=== WELCOME TO THE EMPLOYEE EVALUATION PROGRAM ===");
Console.WriteLine("==================================================");
Console.WriteLine(" ");

var employee1 = new Employee("Paweł","Zduński",28);

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
        employee1.AddRating(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd : {ex.Message}");
    }

    Console.WriteLine("Enter next rating or end the entry by pressing 'X'");
}

var statistics = employee1.GetStatistics();

Console.WriteLine(" ");
Console.WriteLine($"Statistics for {employee1.Name} {employee1.Surname}");
Console.WriteLine($"There are {statistics.Counter} correct ratings given");
Console.WriteLine($"Minimal value: {statistics.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics.Max:0.00}");
Console.WriteLine($"Average value: {statistics.Average:N3}({statistics.AverageString})");