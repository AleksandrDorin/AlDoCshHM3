// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void fillarray(int[] num)
{
    int len = num.Length;
    int i = 0;
    while (i < len)
    {
        num[i] = new Random().Next(0, 10);
        i++;
    }
}
void printarray(int[] element)
{
    int len = element.Length;
    int i = 0;
    while (i < len)
    {
        Console.Write($"{element[i]} ");
        i++;
    }

}
void findsum(int[] array)
{
    int len = array.Length;
    int i = 0;
    int sum = 0;
    while (i < len)
    {
        sum += array[i];
        i++;
    }
    Console.WriteLine($"Сумма элементов равна {sum}");
}
int[] array = new int[12];
fillarray(array);
printarray(array);
Console.WriteLine("");
findsum(array);