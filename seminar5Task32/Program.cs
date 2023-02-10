// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();
int [] GetArray (int size, int minValue, int maxValue )
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, (maxValue+1));
       
    }
    return res;
}


int size = InputNumber("Введите размер массива");
int minValue = InputNumber("Введите минимальное значение в массиве");
int maxValue = InputNumber("Введите максимальное значение в массиве");
int[] barray = GetArray(size, minValue, maxValue );

barray = GetArray(size, minValue, maxValue );
Console.WriteLine("изначально ["+String.Join(", ",(barray))+"]");


int[] ChangeSign(int[] someArray)
{
    int[] res = someArray;
    for (int i = 0; i <= res.Length - 1; i++) res[i] *= (-1);
    return res;
    //Console.Write("["+String.Join(", ",(someArray))+"]");
    // Console.WriteLine();
}

int InputNumber(string message)
{
    //Выводит предложение message и в ответе получает число. Проверку не производит
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

barray = ChangeSign(barray);
Console.Write("потом ["+String.Join(", ",(barray))+"]");