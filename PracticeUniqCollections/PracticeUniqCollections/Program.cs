/* Create a UniqueCollection class that implement ICollection interface
 * ,Choose any collection class type to hold the data items, 
 * allow to enter only unique items to the data collection */
using PracticeUniqCollections;
class Program
{
    static void Main()
    {
        UniqueCollection studentsList = new UniqueCollection();

        Console.WriteLine("Adding students to list:  ");
        studentsList.Add("Itamar");
        studentsList.Add("Noa");
        studentsList.Add("Ido");
        studentsList.Add("Amir");

        Print(studentsList);

        // Testing same name
        Console.WriteLine("Adding Ido again \n");
        studentsList.Add("Ido");

        Console.WriteLine("Removing Noa");
        studentsList.Remove("Noa");

        Print(studentsList);

        Console.WriteLine("Removing Tomer");
        studentsList.Remove("Tomer");

    }


    public static void Print(UniqueCollection list)
    {
        Console.WriteLine("\n Students List:");
        foreach(string name in list)
        {
            Console.Write(name + ", ");
        }
        Console.WriteLine("\n");
    }


}