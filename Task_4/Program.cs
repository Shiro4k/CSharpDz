//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.Write("Введите Число 1 : ");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Число 2 : ");
int numB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Число 3 : ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (max < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}
System.Console.Write("Максимальное -> ");
System.Console.Write(max);

