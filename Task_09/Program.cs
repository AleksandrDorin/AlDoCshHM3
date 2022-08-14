// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

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
void diffnum(int[] num)
{
    double diffnum = 0;
    double maxnum = 0;
    double minnum = num[0];
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > maxnum)
        {
            maxnum = num[i];
        }
        else if (num[i]<minnum)
        {
            minnum = num[i];
        }
    }
    diffnum = maxnum - minnum;
    Console.WriteLine($"Разница между максимальным ({maxnum}) и минимальным ({minnum}) значениями в массиве будет равна: {diffnum} "); 
}

int[] array = new int[10];
fillarray(array);
Console.WriteLine("Задан массив: ");
printarray(array);
Console.WriteLine("");
diffnum(array);