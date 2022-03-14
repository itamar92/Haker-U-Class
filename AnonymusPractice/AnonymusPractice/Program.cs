class Program
{
    public delegate bool FilterCondition(int num);

    public static void Main()
    {
        FilterCondition HasSameNumber = delegate (int num)
        {
            string str = num.ToString();
            if (str.Length == 1)
                return false;
            
            if (num > 10)
            {
                for (int i = 0; i < str.Length-1; i++)
                {
                    if (str[i] == str[i + 1])
                        continue;
                    else return false;
                }
                return true;
            }
            else return false;
        };


        int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
        int[] evenArray = GetFiltered(array, delegate (int number){return number % 2 == 0;});
        int[] notEvenArray = GetFiltered(array, delegate (int number) { return number % 2 != 0; } );
        int[] has3Array = GetFiltered(array, delegate (int number) 
        {
            return number.ToString().Contains('3');
        });
        int[] hasSameNumberArray = GetFiltered(array, HasSameNumber);
        //
        Console.WriteLine("Original array items:");
        Print(array);
        Console.WriteLine("\n********************");
        Console.WriteLine("Even array items:");
        Print(evenArray);
        Console.WriteLine("\n********************");
        Console.WriteLine("Not even array items:");
        Print(notEvenArray);
        Console.WriteLine("\n********************");
        Console.WriteLine("Has 3 in array items:");
        Print(has3Array);
        Console.WriteLine("\n********************");
        Console.WriteLine("Has same number in array items:");
        Print(hasSameNumberArray);
        Console.WriteLine("\n********************");

    }

    public static int[] GetFiltered(int[] array, FilterCondition d)
    {
        //  List<int> temp_list = new List<int>();
        int[] temp_list = new int[0];
        foreach (int number in array)
        {
            if (d(number))
            {
                // temp_list.Add(number);
                Array.Resize(ref temp_list, temp_list.Length + 1);
                temp_list[(temp_list.Length) - 1] = number;
            }
        }
        return temp_list.ToArray();
    }

    public static void Print(int[] arrays)
    {
        foreach (var item in arrays)
        {
            Console.Write($"{item}, ");
        }
    }
}












