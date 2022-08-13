// Написать программу замену элементов массива на противоположные

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
void opposite(int[] element)
{
    for (int i = 0; i < element.Length; i++)
    {
        element[i] *= -1;
    }
}

int[] array = new int[10];

fillarray(array);
Console.WriteLine("Создан массив: ");
printarray(array);
Console.WriteLine("");
opposite(array);
Console.WriteLine("Элементы массива были заменены на противоположные: ");
printarray(array);

