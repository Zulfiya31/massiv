//Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76
///  через цикл for идет а если запрашиваю while то запрашивает переменную i новую . Подскажите что можно сделать?
Console.WriteLine("Введите размер массива ");
int get = int.Parse(Console.ReadLine());
//int[]array = new  int[5];

//array[0]=3;
//array[1]=7;
//array[2]=22;
//array[3]=2;
//array[4]=78;
double[]array = new double [get];
for(int i=0; i<array.Length;i++){
Console.Write("Введите значения  каждого элемента массива  под индексом {i}");

array[i] = double.Parse (Console.ReadLine());
}
double count = 0;
double max = array[0];
double min = array[0];

for (int i=0; i<array.Length;i++){
    if (array[i]>max){
        max = array[i];
    }
    if (array[i]<min){
        min = array[i];
    }
}
count = max - min;
Console.WriteLine ("массив ["+ string.Join(",", array)+ "]" +"=>"+ (count));
