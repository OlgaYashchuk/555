// See https://aka.ms/new-console-template for more information
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double Res()
{
Console.Write ("Введите количество чисел в массиве  ");
int N = Convert.ToInt32(Console.ReadLine());
double DifMaxMin = 0;
double [] numbers = new double[N];
 for (int i=0; i<N; ++i)
 {
    numbers[i]=new Random().Next(-100, 100);
 }
 Console.Write("[");
  for (int i=0; i<N-1; ++i)
 {
  Console.Write ($"{numbers[i]}, ");
 }
  Console.Write(numbers[N-1]+"]");
double Min=numbers[0];
for (int i=0; i<N; ++i)
{
    if (numbers[i]<Min)
    {
        Min=numbers[i];
    }  
}
double Max=numbers[0];
for (int i=0; i<N; ++i)
{
    if (numbers[i]>Max)
    {
        Max=numbers[i];
    } 
}
    DifMaxMin = Max - Min;
     return DifMaxMin;  
 }
Console.WriteLine ($" разница между максимом и минимумом- {Res()}");


