// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//Задача 32: Напишите программу замена элементов массива: положительны
//элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

//-------
//Ввод исходных данных
int size = InputNumber("Введите размер массива");
int min = InputNumber("Введите минимальное значение в массиве");
int max = InputNumber("Введите максимальное значение в массиве");
int[] array = GetArray(size, min, max);

//--------
//Работаем
Console.Clear();
PrintArray(array);
array = ChangeSign(array);
PrintArray(array);

//---------
//Методы
int[] ChangeSign(int[] someArray)
{
    //Меняет знак у элементов массива
    int[] res = someArray;
    for (int i = 0; i <= res.Length - 1; i++) res[i] *= (-1);
    return res;
}
int[] GetArray(int length, int min = -1, int max = 1)
{
    //Генерирует массив целых чисел заданной длинны length
    //По-умолчанию числа в массиве от -1 до +1, меняется аргументами min и max
    int[] res = new int[length - 1];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max + 1);
    return res;
}
void PrintArray(int[] someArray)
{
    //Выводит массив в консоль в виде [,,]
    Console.Write("[");
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}
int InputNumber(string message)
{
    //Выводит предложение message и в ответе получает число. Проверку не производит
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}
