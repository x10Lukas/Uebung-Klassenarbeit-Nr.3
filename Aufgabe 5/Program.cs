int size = 5;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write("#");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}