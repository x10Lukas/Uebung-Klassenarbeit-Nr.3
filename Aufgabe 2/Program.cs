int sum = 0;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Die Summe der Zahlen von 0 bis 100, die durch 3 oder 5 teilbar sind, beträgt: {sum}");
Console.ReadLine();