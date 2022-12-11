int i = 0;
double Sqrty(int num)
{

    if (i == 1000)
    {
        return 10;
    }
    else
    {
        i++;
        return Math.Sqrt(num + Sqrty(num));
    }
}

// Console.Write("enter a number: ");
// int number = int.Parse(Console.ReadLine());

int k = 1;
while (k<21)
{   
    i = 0;
    Console.Write("k =" + k );
    Console.WriteLine(" " + Sqrty(k));
    k ++;
}


