System.Console.Write("Введите Число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
while (count < N)
{
    if (sum < N)
    {
        sum = sum + 2;
        System.Console.WriteLine(sum);
    }
    count++;
}