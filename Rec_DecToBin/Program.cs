Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int Binary(int num)
{
    if (num == 0)
    {
        Console.Write(num);
        return 0;
        
    }
    if (num == 1)
    {
        Console.Write(num);
        return 0;
        
    }
    else
    {
        int rem = num%2;
        
        Console.Write(rem);
        
        return (rem + Binary(num/2));
    }
}

Binary(number);

