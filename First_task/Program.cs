Console.Write("Enter first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == Math.Sqrt(a))
{
    Console.Write("The first number is squared of the second one");
}

else
{
    Console.Write("The first number is NOT squared of the second one");
}