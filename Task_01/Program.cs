// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void fillarray(int[] number)
{
    int len = number.Length;
    int i = 0;
    while (i < len)
    {
        number[i] = new Random().Next(0, 2);
        i++;
    }
}

void printarray(int[] elements)
{
    int length = elements.Length;
    int i = 0;
    while (i < length)
    {
        Console.Write($"{elements[i]} ");
        i++;
    }
}

int[] array = new int[8];
fillarray(array);
printarray(array);