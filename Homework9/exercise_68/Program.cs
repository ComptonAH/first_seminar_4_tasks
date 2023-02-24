int Ackermann(int m,int n)
{
    if (m == 0) return n+1;
    if (n == 0 && m > 0) return Ackermann(m-1,1);
    if (n > 0 && m > 0) return Ackermann(m-1,Ackermann(m,n-1));
    return Ackermann(m,n);
}

Console.WriteLine("Enter the first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m,n);
Console.WriteLine(result);