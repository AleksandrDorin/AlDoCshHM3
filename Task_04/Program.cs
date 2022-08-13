// Определить, присутствует ли в заданном массиве, некоторое число

void fillarray(int[] array)
{
    Console.WriteLine("Введите масмимальное значение массива: ");
    int max = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение массива: ");
    int min = int.Parse(Console.ReadLine());
    
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
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
bool Contains(int[] array, int value)
{
   foreach(var element in array)
        if(element==value)
            return true;
    return false;
}

int[] array = new int[10];
fillarray(array);
Console.WriteLine("Задан случайный массив: ");
printarray(array);
Console.WriteLine("");
Console.WriteLine("Введите искомое число: ");
int element = int.Parse(Console.ReadLine());
bool contains = Contains(array, element);
Console.WriteLine(contains ? "Искомое число найдено!" :
    "Искомое число не найдено!");

