// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.Write("Введите Число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
while (count < N)
{
    System.Console.WriteLine(count);
    count+=2;
}