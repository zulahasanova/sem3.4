/*  Напишите программу,
 которая выводит массив из 8 элеменотов, 
 заполненный нулями и единицами в случайном порядке.  */

 int[] array = new int[8];
 void RandomArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
        Console.Write($"{array[i]} ");
    }
 }
 RandomArray(array);
