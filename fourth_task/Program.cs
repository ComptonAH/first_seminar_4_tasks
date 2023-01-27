Console.Write("Enter an integer three-digit number (from 100 to 999): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N%10}");
