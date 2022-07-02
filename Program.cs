// Преобразование десятичного числа в двоичное


void Remainder(int a, int b)
{
    int[] array = new int[b];
    int i = 0;
    while (a > 0)
    {
        array[i] = a % 2;
        i++;
        a = a / 2;
    }

    for (int j = array.Length - 1; j >= 0; j--)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 0;
int mem = number;

while (number > 0)
{
    number = number / 2;
    count++;
}

Remainder(mem, count);