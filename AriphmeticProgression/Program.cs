
int SumArithmeticProgression (int theFirstMemberOfTheProgression, int theLastMemberOfTheProgression )

{
    int sum = 0;
    if (theFirstMemberOfTheProgression == theLastMemberOfTheProgression ) return sum;
    else 
    {
        sum += theFirstMemberOfTheProgression*theFirstMemberOfTheProgression;
        theFirstMemberOfTheProgression++;
        return sum + SumArithmeticProgression(theFirstMemberOfTheProgression,theLastMemberOfTheProgression );
    }
}

Console.WriteLine(SumArithmeticProgression (1, 6));

