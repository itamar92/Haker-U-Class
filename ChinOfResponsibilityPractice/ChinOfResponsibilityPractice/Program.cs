using ChinOfResponsibilityPractice;

class Program
{
    static void Main()
    {
        Console.WriteLine("Car entering to the Garage");
        Car car = new Car() { Model = "KIA Niro 2018" };
        BasicCarHandler basicCarHandler = new BasicCarHandler();
        MechanicHandler mechanicHandler = new MechanicHandler();
        ElectricianHandler electricianHandler = new ElectricianHandler();
        ExpertHandler expertHandler = new ExpertHandler();

        Console.WriteLine("Starting the tests....\n");
        basicCarHandler.SetNext(mechanicHandler);
        mechanicHandler.SetNext(electricianHandler);
        electricianHandler.SetNext(expertHandler);

        Console.WriteLine("Finding where is the problam: \n");
        basicCarHandler.HandleRequest(car);

        if(car.HasProblam)
        {
            Console.WriteLine($"{car.Model} {car.Error}");
        }
        else
        {
            Console.WriteLine("No problam where found ! ");
        }


    }

}