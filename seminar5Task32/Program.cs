// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int size = InputNumber("Введите размер массива");
int minValue = InputNumber("Введите минимальное значение в массиве");
int maxValue = InputNumber("Введите максимальное значение в массиве");
int[] array = GetArray(size, minValue, maxValue );


int [] GetArray (int size, int minValue, int maxValue )
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, (maxValue+1));       
        //if (minValue < 0) minValue = minValue*(-1);
        //if (maxValue < 0) minValue = minValue*(-1);
    }
    return res;
}

array = GetArray(size, minValue, maxValue );
Console.WriteLine("сгенерированный массив из случайных чисел ["+String.Join(", ",(array))+"]");


int[] ChangeSign(int[] someArray)
{
    int[] res = someArray;
    for (int i = 0; i <= res.Length - 1; i++) res[i] *= (-1);
    return res;
}

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

array = ChangeSign(array);
Console.Write("измененные элементов на противоположные ["+String.Join(", ",(array))+"]");