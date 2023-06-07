int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int tempNumber = 0;

Console.Write("Дан массив: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\nНа сколько позиций влево его сдвинуть?");

int shiftRepetitions = Console.Read();

for (int i = 0; i < shiftRepetitions; i++)
{
    tempNumber = numbers[0];

    for (int j = 0; j < numbers.Length - 1; j++)
    {
        numbers[j] = numbers[j + 1];
    }

    numbers[numbers.Length - 1] = tempNumber;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}