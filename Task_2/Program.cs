System.Console.Write("Введите Число 1 : ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Число 2 : ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    System.Console.Write("1 Число больше оно ровно :  ");
    System.Console.WriteLine(numA);
}
else
{
    System.Console.Write("2 Число больше оно ровно :  ");
    System.Console.WriteLine(numB);
}