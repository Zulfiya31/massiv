// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве
Console.WriteLine("Введите размер массива ");
int get = int.Parse(Console.ReadLine());
int sum = 0;
int[]array = new int[get];
for (int i=0; i<array.Length;i++){
    array[i] = new Random().Next(100,1000);
    }
for (int i = 0;i<array.Length; i++){
    sum = sum+array[i]%2;
    }
    Console.WriteLine ("массив ["+ string.Join(",", array)+ "]" +"=>"+ (sum) + "четных числа");