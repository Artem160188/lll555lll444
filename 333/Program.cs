// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.
//{
var rnd = new Random();
var arr = new int[15];
for (int i = 0; i < arr.Length; i++)
    Console.Write("{0}\t", arr[i] = rnd.Next(100, 1000));
Console.WriteLine();
var odd = arr.Where((element, index) => index % 2 == 0);
Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());

//Console.ReadKey();
//}
