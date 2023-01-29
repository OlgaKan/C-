// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три любых целых числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max)
{
    Console.WriteLine (max = b);
}
if (c > max)
{
    Console.WriteLine (max = c);
}

 Console.WriteLine ("Наибольшее число -->" + max);
