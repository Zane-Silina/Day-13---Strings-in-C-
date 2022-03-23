
string[] cities = { "Copenhagen", "Paris", "Tokyo", "Bristol", "Mumbai", "Delhi", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis" };
int cityCount = 0;
int cityCount2 = 0;
int cityCount3 = 0;
int cityCount4 = 0;

Console.WriteLine("Please enter the first letter:");
char.TryParse(Console.ReadLine(), out char firstLetter);
for (int i = 0; i < cities.Length; i++)
{
    if (cities[i][0] == firstLetter)
    {
        Console.WriteLine($"The city starting on letter '{firstLetter}' is {cities[i]}");
        cityCount++;
    }
}
if (cityCount == 0)
{
    Console.WriteLine($"There are no cites starting with a letter '{firstLetter}'.");
}
Console.WriteLine("\nPlease enter the last letter:");
char.TryParse(Console.ReadLine(), out char lastLetter);
for (int i = 0; i < cities.Length; i++)
{
    if (cities[i][cities[i].Length - 1] == lastLetter)
    {
        Console.WriteLine($"The city ending with letter '{lastLetter}' is {cities[i]}");
        cityCount2++;
    }
}
if (cityCount2 == 0)
{
    Console.WriteLine($"There are no cites ending with a letter '{lastLetter}'.");
}
Console.WriteLine("\nPlease enter the word length:");
int.TryParse(Console.ReadLine(), out int wordLength);
for (int i = 0; i < cities.Length; i++)
{
    if (cities[i].Length == wordLength)
    {
        Console.WriteLine($"The city containing {wordLength} letters is {cities[i]}");
        cityCount3++;
    }
}
if (cityCount3 == 0)
{
    Console.WriteLine($"There are no cites containing {wordLength} letters.");
}
Console.WriteLine("\nPlease enter a letter that might be in the name of a city");
char.TryParse(Console.ReadLine(), out char mightLetter);

for (int i = 0; i < cities.Length; i++)
{
    foreach (char c in cities[i])
    {
        if (c == mightLetter)
        {
            Console.WriteLine($"The city containing a letter '{mightLetter}' is {cities[i]}");
            cityCount4++;
            break;
        }
    }
}
if (cityCount4 == 0)
{
    Console.WriteLine($"There are no cites containing a letter '{mightLetter}'.");
}