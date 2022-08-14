// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
void TheProductOfNumbers(int[] number)
{
    int sum = 0;
    int j = 9;
    int i = 0; 
    while (i < number.Length / 2)
    {
    sum = number[i] * number[j];
    Console.WriteLine($"Произведение пары: {number[i]} * {number[j]} = {sum} ");
    i++;
    j--;
    if(i==j)
    break;
    }

}

int[] array = new int[10];
fillarray(array);
Console.WriteLine("Задан массив: ");
printarray(array);
Console.WriteLine("");
TheProductOfNumbers(array);