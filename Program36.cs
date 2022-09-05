// See https://aka.ms/new-console-template for more information

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

double Res()
{
Console.Write ("Введите количество чисел в массиве  ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];

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

int Sum=0;
for (int i=0; i<N; ++i)
{
    if (i%2!= 0)
       Sum= Sum+numbers[i];
    
}
    return Sum;
}

Console.WriteLine ($" Сумма элементов  на нечетных позициях- {Res()}");