Console.Write("enter the number of terms: ");
int number = int.Parse(Console.ReadLine());

int Terms(int num)
{

    if (num <= 0)
    {
        return 0;
    }
    else
    {
        return num + Terms(num - 1);
    }
}

Console.Write("The sum of terms is " + Terms(number));

