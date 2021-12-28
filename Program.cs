//Написать программу, которая из имеющегося массива целых чисел 
//формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

int[] firstArray = new int[7];

void FirstArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(3, 12);
    }
}

void PrintArray(int[] arr2)
{
    
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]}, ");
    }
    Console.Write("]");
}

int [] SecondArray (int [] arr3) 
{ 
   
    int size = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i] > 8)
        {
            size = size + 1;
        }
    }
    int [] temp = new int[size];
    int j =0;
    for (int i = 0; i < arr3.Length; i++)
    {

        if (arr3[i] > 8)
        {
            temp[j] = arr3[i];
            j++;
        }
    }
    return temp;
 } 


FirstArray(firstArray);
PrintArray(firstArray);
Console.Write(" => ");
Console.Write("[");
PrintArray(SecondArray(firstArray)); 




