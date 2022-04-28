class Program
{
    static void Main()
    {
        string Message = @" Please pick your preferred diet:

           ================MENUE=================
                        vg  - Vegan

                        veg - Vegaterian

                        om  - Omnivore " + "\n";

        bool running = true;
        while (running)
        {
            Console.WriteLine(Message);
            DietFactory dietFactory = new DietFactory();
            IBasicDiet diet = dietFactory.GetDiet(Console.ReadLine().ToLower());
            if (diet != null)
            {
                diet.PrintMenu();
                Console.WriteLine(" Try another one? (y/n ) \n"  );
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "y":
                        running = true;
                        Console.WriteLine();
                        continue;
                    case "n":
                        running = false;
                        Console.WriteLine(" \n Good luck with your new diet !");
                        break;
                    default:
                        Console.WriteLine("Please choose y/n ");
                        break;
                }



                running = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please type the letters from the menue. \n");
                
            }
        }
    }
}

public class DietFactory
{
    public IBasicDiet GetDiet(string diet)
    {
        switch (diet)
        {
            case "vg":
                return new VeganDiet();
                break;


            case "veg":
                return new VegaterianDiet();
                break;

            case "om":
                return new OmnivoreDiet();
                break;

        }

        return null;
    }
}

public interface IBasicDiet
{
    public void PrintMenu();
}

class VeganDiet : IBasicDiet
{
    public string Name = "Vegan";
    public string Id = "Vg";

    public void PrintMenu()
    {
        string[] menu = { "Vegtables", "Fruits", "Grains", "Nuts" };

        Console.Clear();
        Console.WriteLine("Your diet should include: \n ");
        foreach (string item in menu)
        {
            Console.WriteLine($"{item} \n");
        }
    }
}

class VegaterianDiet : IBasicDiet
{
    public string Name = "Vegeterian";
    public string Id = "Veg";

    public void PrintMenu()
    {
        string[] menu = { "Vegtables", "Fruits", "Grains", "Nuts", "Dairy", "Eggs" };

        Console.Clear();
        Console.WriteLine("Your diet should include: \n ");
        foreach (string item in menu)
        {

            Console.WriteLine($"{item} \n");
        }
    }
}

class OmnivoreDiet : IBasicDiet
{
    public string Name = "Omnivore";
    public string Id = "Om";

    public void PrintMenu()
    {
        string[] menu = { "Vegtables", "Fruits", "Grains", "Nuts", "Dairy", "Eggs", "Meat", "Fish" };

        Console.Clear();
        Console.WriteLine("Your diet should include: \n ");
        foreach (string item in menu)
        {
            Console.WriteLine($"{item} \n");
        }
    }
}