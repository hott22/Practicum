//Написать программу, которая из имеющегося массива целых чисел 
//формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

int[] array = new int[7];
int[] secondArray = new int[array.Length]; 

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

void SecondArray(int [] temp, int [] arr3) 
{ 
    for (int i = 0; i < temp.Length; i++) 
    { 
        
        if(temp[i] > 8 )  
        { 
            arr3[i] = temp[i]; 
            Console.Write(arr3[i] + ", "); 
        } 
        
    } 
} 


FirstArray(array);
PrintArray(array);
Console.Write(" => ");
Console.Write("[");
SecondArray(array, secondArray); 
Console.WriteLine("]");


