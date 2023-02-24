string RecursiveSequence(int N)
{
    string Sequence = string.Empty;
    Sequence = Convert.ToString(N) + " ";
    if (N == 1) return $"{1}";
    return Sequence + RecursiveSequence(N-1);
}

Console.WriteLine("Enter the end of the sequence:");
int N = Convert.ToInt32(Console.ReadLine());
string RecSeq = RecursiveSequence(N);
Console.WriteLine("{0}", RecSeq.Replace(' ', ','));