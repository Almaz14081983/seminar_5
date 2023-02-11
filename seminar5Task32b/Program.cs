// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int size = InputNumber("Введите размер массива ");
int min = InputNumber("Введите минимальное значение ");
int max = InputNumber("Введите максимальное значение ");
int[] array = GetArray(size, min, max);

PrintArray(array);
array = ChangeSign((array));
PrintArray(array);

int[] ChangeSign(int[] someArray)
{
    int[] res = someArray;
    for (int i=0; i<=res.Length-1; i++) res[i]*=(-1);
    return res;
}

int [] GetArray (int size, int min, int max )
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, (max+1));
       
    }
    return res;
}

void PrintArray (int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i < someArray.Length-1; i++)
    {
        Console.Write($"{someArray[i]},");
    }
    Console.WriteLine($"{someArray[someArray.Length-1]} ]");
}

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

