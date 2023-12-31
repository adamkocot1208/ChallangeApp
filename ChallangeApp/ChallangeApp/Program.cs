﻿using ChallangeApp;

Console.WriteLine("=== WELCOME TO THE EMPLOYEE EVALUATION PROGRAM ===");
Console.WriteLine("==================================================");
Console.WriteLine(" ");

var emp1 = new EmployeeInFile("Paweł","Zduński", 'M');
emp1.RatingAdded += EmployeeRatingAdded;

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
        emp1.AddRating(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd : {ex.Message}");
    }

    Console.WriteLine("Enter next rating or end the entry by pressing 'X'");
}

var statistics = emp1.GetStatistics();

Console.WriteLine(" ");
Console.WriteLine($"Statistics for {emp1.Name} {emp1.Surname}");
Console.WriteLine($"There are {statistics.Counter} correct ratings given");
Console.WriteLine($"Minimal value: {statistics.Min:0.00}");
Console.WriteLine($"Maximum value: {statistics.Max:0.00}");
Console.WriteLine($"Average value: {statistics.Average:N3}({statistics.AverageString})");

void EmployeeRatingAdded(object sender, EventArgs args)
{
    Console.WriteLine("New rating has been added :)");
}