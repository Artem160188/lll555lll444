// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] FillPrintArray() 

        // int[] array = new int[30]; 
        // for (int i = 0; i < 30; i++) 
        // { 
        //     array[i] = new Random().Next(100, 999); 
        //     Console.Write(array[i] + " "); 
        // } 
int[] FillPrintArray() 
{ 
    { 
        int[] array = new int[30]; 
        for (int i = 0; i < 30; i++) 
        { 
            array[i] = new Random().Next(100, 1000); 
            Console.Write(array[i] + " "); 
        } 
        return array; 
    } 
} 
 
int Elements(int[] array) 
{ 
    int count = 0; 
    foreach (int el in array) 
    { 
        //if (el >= 100 && el <=500) count++; 
        if (el%2==0) count++; 
    } 
    return count; 
} 
 
int[] array = FillPrintArray(); 
Console.WriteLine(); 
Console.WriteLine($"количество чётных чисел в массиве = {Elements(array)}");