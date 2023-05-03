int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int tempNumber = 0;
int firstNumber = numbers[0];

Console.Write("Дан массив: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\nНа сколько позиций влево его сдвинуть?");

int shiftRepetitions = Console.Read();

for (int i = 0; i < shiftRepetitions; i++)
{ 
    for (int j = 0; j < numbers.Length; j++)
    {
        if (j != numbers.Length - 1)
        {
            tempNumber = numbers[j + 1];
            numbers[j] = tempNumber;
        }
        else
        {
            numbers[j] = 0;
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] + " ");
}