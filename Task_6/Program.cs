// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.Write("Введите Число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0 )
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}