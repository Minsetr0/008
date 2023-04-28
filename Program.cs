int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
int tempNumber = 0;
int firstNumber = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (i != numbers.Length - 1)
    {   
        tempNumber = numbers[i + 1];
        numbers[i] = tempNumber;
    }
    else
    {
        numbers[i] = 0;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] + " ");
}
