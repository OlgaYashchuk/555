// See https://aka.ms/new-console-template for more information
// Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

double Res()
{
Console.Write ("Введите количество чисед в массиве  ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];

 for (int i=0; i<N; ++i)
 {
    numbers[i]=new Random().Next(100, 999);
 }
 Console.Write("[");
  for (int i=0; i<N-1; ++i)
 {
  Console.Write ($"{numbers[i]}, ");
 }
  Console.Write(numbers[N-1]+"]");

int count=0;
for (int i=0; i<N; ++i)
{
    if (numbers[i]%2 ==0 ) 
    {
        count++;
    }
}
    return count;
}

Console.WriteLine ($" Количество четных элементов - {Res()}");
