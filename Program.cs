//Написать программу, которая из имеющегося массива целых чисел 
//формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

int[] array = new int[10];
void FirstArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(3, 12);
    
        Console.Write($"{arr[i]} ");
    }
}


void SecondArray (int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] > 8) Console.Write($"{arr2[i]} ");
    }
}

FirstArray (array);
Console.WriteLine();
SecondArray (array);

