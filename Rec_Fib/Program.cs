Console.Write("Enter the number of members of the sequence ");
int number = int.Parse(Console.ReadLine());

int Fib(int number)
{
    if (number == 0)
    {
        return 0;
    }
    if (number == 1)
    {
        return 1;
    }
    else
    {
        return (Fib(number-1) + Fib(number-2));
    }
}


Console.Write($"The value of the {number} term of the sequence is {Fib(number)} ");

