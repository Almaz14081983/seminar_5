//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = InputNumber("Введите размер массива");
int min = InputNumber("Введите минимальное значение в массиве");
int max = InputNumber("Введите максимальное значение в массиве");
int[] array = GetArray(size, min, max );

int[] GetArray(int size, int min, int max)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;    
}

array = GetArray(size, min, max );
// Console.WriteLine("сгенерированный массив из случайных ["+String.Join(", ",(array))+"]");

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

void PrintArray(int[] someArray)
{
    //Выводит массив в консоль в виде [,,]
  Console.Write("сгенерированный массив из случайных чисел [");
  for (int i = 0; i < someArray.Length - 1; i++)
  {
    Console.Write($"{someArray[i]}, ");
  }
  Console.WriteLine($"{someArray[someArray.Length - 1]}]");
    
 //   Console.WriteLine($"четных {ChangeSign(numberOfEven)}")

}

int[] SumOfOdd(int[]someArray)
{         
    int oddPosition = 0;  
   //int i = 1;
    int count = 1;
    for(int i = 0; i<= someArray.Length-1; i=i+1) 
    { 
        if(i%2!=0) oddPosition = oddPosition + someArray[i]; 
        //if(i<= someArray.Length) oddPosition = oddPosition + someArray[i]; 
    }    
    count = count + 1;
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {oddPosition}");
    return someArray;           
}

PrintArray(array);
array = SumOfOdd(array);


//int[] ChangeSign(int[]someArray)
//{
 //   int count = 0;
 //   int numberOfEven = 0;
 //   int numberOfOdd = 0;
 //   for(int i = 0; i<= someArray.Length-1; i++) 
 //   { 
 //       if (someArray[i]%2==0) numberOfEven = numberOfEven +1 ;   
 //       if (someArray[i]%2!=0) numberOfOdd = numberOfOdd +1 ;     
 //   }
 //   count = count + 1;
 //   Console.WriteLine($"из них количество четных чисел: {numberOfEven}");
 //   Console.WriteLine($"из них количество не четных чисел: {numberOfOdd}");
 //   return someArray;          
//}

// PrintArray(SumOfOdd(array));
// Console.Write("сумма нечетных чисел: ["+String.Join(", ",(array))+"]");
// Console.WriteLine($"сумма нечетных чисел: {oddPosition}")