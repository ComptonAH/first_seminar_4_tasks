Console.Write("Enter an integer number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;

while (i<=N)
{
    Console.Write($"{i},");
    i++;
}