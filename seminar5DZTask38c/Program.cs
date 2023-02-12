//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//using Geekbrains;

//string format = "{0:F2}";                   //Формат вывода чисел типа double
//Console.Clear();

//double[] arr = DoubleArray.MakeCustom();    //Задаем массив случайных чисел
//DoubleArray.WriteLine(arr, format);
//double dif = DoubleArray.Max(arr) - DoubleArray.Min(arr);
//Console.WriteLine($"Разница между максимумом и минимумом в массиве равна {string.Format(format, dif)}.");
int[] GetArray(int size, int min, int max)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;    
}

double num1 = new Random().Next(0,2);
Console.WriteLine(num1);
double num2 = new Random().Next(0,2);
Console.WriteLine(num2);
double result = num1/num2;
Console.WriteLine(result);
