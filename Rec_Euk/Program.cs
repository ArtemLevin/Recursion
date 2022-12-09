Console.Write("Enter the first number: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int B = int.Parse(Console.ReadLine());

int Euklid(int A, int B)
{
    if (B == 0)
    {
        return A;
    }
    else
    {
        int C = A%B;
        return Euklid(B, C);
    }
}

Console.Write($"GCD is {Euklid(A, B)} ");
