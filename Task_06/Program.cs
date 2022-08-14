// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void fillarray(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 150);
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
void findelement(int[] element)
{
    int count = 0;
    for (int i = 0; i < element.Length; i++)
    {
        if (element[i] > 10 && element[i] < 100)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Количество элементов из отрезка [10,99] = {count} ");
}


int[] array = new int[15];
fillarray(array);
printarray(array);
Console.WriteLine("");
findelement(array);