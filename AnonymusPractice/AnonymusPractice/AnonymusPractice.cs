using System;
namespace AnonymusLambdaPractice
{
    public delegate bool FilterCondition(int num);

    public class AnonymusPractice
	{
        FilterCondition IsEvan = delegate (int number)
        {
            return number % 2 == 0;
        };

        FilterCondition IsNotEvan = (int number) => !(number % 2 == 0);

        FilterCondition Has3 = (int number) => { return number.ToString().Contains('3'); };

        FilterCondition HasSameNumber = (int num) =>
        {
            string str = num.ToString();
            if (str.Length == 1)
                return false;

            if (num > 10)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                        continue;
                    else return false;
                }
                return true;
            }
            else return false;
        };

    }
}

