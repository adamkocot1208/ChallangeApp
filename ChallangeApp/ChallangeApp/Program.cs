//Program zliczający liczbę cyfr w podanej liczbie

Console.WriteLine("Podaj liczbę, którą chcesz sprawdzić: ");
string number = Console.ReadLine();
char[] letters = number.ToArray();

int count = 0;

List<string> digits = new List<string>();
for (int i = 0; i < 10; i++)
{
    digits.Add(i.ToString());
}

foreach (string digit in digits)
{
    foreach (char c in letters)
    {
        if (c.ToString() == digit)
        {
            count++;
        }
    }
    Console.WriteLine(digit + " => " + count.ToString());
    count = 0;
}