//Написать программу, которая из имеющегося массива целых чисел 
//формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

int[] firstArray = new int[7];

void Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(3, 12);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

int [] AlteredArray (int [] array, int argument) 
{ 
   
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > argument )
        {
            size = size + 1;
        }
    }
    int [] secondArray = new int[size];
    int index =0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > argument )
        {
            secondArray[index] = array[i];
            index++;
        }
    }
    return secondArray;
 } 


Array(firstArray);
PrintArray(firstArray);
Console.Write(" => ");
int [] secondArray = AlteredArray(firstArray, 8);
PrintArray(secondArray); 




