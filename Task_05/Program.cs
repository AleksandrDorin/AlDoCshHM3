// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void fillarray(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}
void printarray(int[] num)
{
    int len = num.Length;
    int i = 0;
    while (i < len)
    {
        Console.Write($"{num[i]} ");
        i++;
    }
}
void parity(int[] element)
{
    int even = 0;
    int uneven = 0;
    for( int i = 0; i < element.Length; i++)
    
    if(element[i] % 2 == 0)
    {
        even += 1;
    }
    else
    {
        uneven += 1;
    }
    Console.WriteLine($"Колличество четных элементов равно: {even}" );
    Console.WriteLine($"Колличество нечетных элементов равно: {uneven}" );
}

int[] array = new int[10];
fillarray(array);
printarray(array);
Console.WriteLine("");
parity(array);