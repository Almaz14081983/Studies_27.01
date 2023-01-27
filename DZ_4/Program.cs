// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()); // numer = N
int start = -N;
while(start <= N )
    {
        Console.Write(start + " ");
        start++;
    }
     

Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int result = number%2;
if(result == 1)
{
    Console.Write("нет, число нечётное");
}
if(result == 0)
{
    Console.Write("да, число является чётным");
}