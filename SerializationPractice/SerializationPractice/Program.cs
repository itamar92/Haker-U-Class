using System.Text.Json;
using SerializationPractice;
class Program
{
    public const string FILEPATHE = "students.json";
    public const int PAYMENT = 10000;
    public static void Main()
    {
        bool running = true;
        string userInput;
        string appMessage = @"
            Choos an action to perform:
            a - Add student
            r - Remove student
            p - Print student list
            sp - Print student payment fee
            q - Quit";

        while (running)
        {
            Console.WriteLine(appMessage);
            userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "a":
                    AddUser();
                    break;
                case "r":
                    Console.WriteLine("Enter user name to remove: ");
                    RemoveUser(Console.ReadLine());
                    break;
                case "p":
                    PrintUsers();
                    break;
                case "sp":
                    PrintUsersPayement();
                    break;
                case "q":
                    running = false;
                    Console.WriteLine("closing  app, Good Bye! ");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

    }


    public static void AddUser()
    {
        string name = "";
        int age = 0;
        while (name == "")
        {
            Console.WriteLine("Enter user name: ");
            name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Name field have to include at leat 1 char, Please try again. ");
            }
        }
        while (age == 0)
        {
            try
            {
                Console.WriteLine("Enter User Age:");
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Invalid age ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Only digit are accepted, please try again", e.Message);
            }
        }
        Users addUser = new Users(name, age);
        List<Users> userList = DeSerializationFromFile();
        foreach (Users user in userList)
        {
            if (user.Name.ToLower() == addUser.Name.ToLower())
            {
                Console.WriteLine($"Cannot add {addUser}. user name already exist");
                return;
            }
        }
        userList.Add(addUser);
        Console.WriteLine($"{addUser} added successfully");
        SerializationToFile(userList);
        Console.Clear();
    }
    public static void RemoveUser(string userName)
    {
        Console.Clear();
        bool removed = false;
        List<Users> userList = DeSerializationFromFile();
        foreach (Users user in userList)
        {
            if (user.Name.ToLower() == userName.ToLower())
            {
                removed = userList.Remove(user);
                SerializationToFile(userList);
                break;
            }
        }
        if (removed)
        { Console.WriteLine($"{userName} removed succesfully "); }
        else
        { Console.WriteLine($"Cannot remove {userName}, user not in list"); }

    }

    public static int Payment(int age)
    {
        if (age > 25)
        {
            return PAYMENT;
        }
        else
            return PAYMENT / 10 * 9;
    }

    public static void PrintUsers()
    {
        List<Users> userList = DeSerializationFromFile();
        foreach (var user in userList)
        {
            Console.WriteLine(user);
        }
    }

    public static void PrintUsersPayement()
    {
        List<Users> userList = DeSerializationFromFile();
        foreach (var item in userList)
        {
            Console.WriteLine($"{item} need to pay {Payment(item.Age)}");
        }
    }
    static void SerializationToFile(List<Users> list)
    {
        Console.WriteLine("SerializeToFile \n");
        string usersJsonString;

        usersJsonString = JsonSerializer.Serialize(list);
        File.WriteAllText(FILEPATHE, usersJsonString);
        Console.WriteLine(usersJsonString + "\n");
    }

    public static List<Users> DeSerializationFromFile()
    {
        string userJasonString = File.ReadAllText(FILEPATHE);
        List<Users> userList = JsonSerializer.Deserialize<List<Users>>(userJasonString);
        return userList;
    }




}

