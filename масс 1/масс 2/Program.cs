//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19    [
Console.WriteLine("Введите размер массива ");
int get = int.Parse(Console.ReadLine());
int sum = 0;
int[]array = new int[get];
for ( int i=0; i<array.Length;i++){
    array[i] = new Random().Next(-100,100);
}
for ( int i=0; i<array.Length;i++){
    if(i%2==1){
       sum = sum + array[i];
    }
    
    }



    Console.WriteLine ("массив ["+ string.Join(",", array)+ "]" +"=>"+ (sum));
