using System.Text.Json;
using SerializationPractice;
class Program
{
    public static string userFilePath = "students.json";

    public static void Main()
    {
        SerializationToFile();

        DeSerializationFromFile();

    }

    static void SerializationToFile()
    {
        Console.WriteLine("SerializeToFile \n");
        string usersJsonString;
        List<Users> userList = new List<Users>()
        {
            new Users() { Age = 45, Name = "Moshe"},
            new Users() { Age = 34, Name = "David" },
            new Users() { Age = 23, Name = "Raine" },
            new Users() { Age = 41, Name = "Joe" },
            new Users() { Age = 24, Name = "Dana" },
            new Users() { Age = 35, Name = "Ramya" },
        };

        usersJsonString = JsonSerializer.Serialize(userList);
        File.WriteAllText(userFilePath, usersJsonString);
        Console.WriteLine(usersJsonString + "\n");

    }

    static void DeSerializationFromFile()
    {
        Console.WriteLine("DesrilalizeFromFile \n");
        string userJasonString = File.ReadAllText(userFilePath);
        List<Users> userList = JsonSerializer.Deserialize<List<Users>>(userJasonString);
        Print(userList);

        static void Print(List<Users> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} {item.Payment()}");
            }
        }

    }
}

