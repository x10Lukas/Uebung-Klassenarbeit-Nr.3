int[] ez = { 45, 10, 15, 4 };

for (int i = 0; i < ez.Length - 1; i++)
{
    if (ez[i] < ez[i + 1])
    {
        int tmp = ez[i];
        ez[i] = ez[i + 1];
        ez[i + 1] = tmp;
    }
}
foreach (int value in ez)
{
    Console.WriteLine(value);
}