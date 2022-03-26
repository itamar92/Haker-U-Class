using CustomLinkedListPractice;

class Program
{
    static void Main()
    {
        CustomLinkedList<int> cll = new CustomLinkedList<int>();
        cll.Add(1);
        cll.Add(2);
        cll.Add(3);
        Console.WriteLine("Enumarating CustomLinkedList items with");
        Console.WriteLine("GetEnumerator:");
        foreach (var item in cll)
            Console.WriteLine(item);

        Console.WriteLine("GetEnumerableDESC:");
        foreach (var item in cll.GetEnumerableDESC())
           Console.WriteLine(item);




    }
}