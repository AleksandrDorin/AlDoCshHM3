// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void fillarray(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
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
void unevensum(int[] element)
{
    int sum = 0;
    for (int i = 0; i < element.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += element[i];
        }
    }
    Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции будет равна {sum} !");
}

int[] array = new int[15];
fillarray(array);
printarray(array);
Console.WriteLine("");
unevensum(array);