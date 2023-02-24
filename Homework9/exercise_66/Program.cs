int RecursiveSequenceSumma(int M, int N)
{
    int Sequence = M;
    if (M == N) return Sequence;
    return Sequence + RecursiveSequenceSumma(M + 1, N);
}

Console.WriteLine("Enter the begining of the sequence:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the end of the sequence:");
int N = Convert.ToInt32(Console.ReadLine());

int RecSeq = RecursiveSequenceSumma(M, N);
Console.WriteLine(RecSeq);