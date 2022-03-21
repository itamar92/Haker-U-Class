using System.Collections.Generic;
using YieldPractice;
//
Agency a1 = new Agency();
a1.Cars = new Car[]{
        new Car(){ ModelYear = 2001 , Maker = "Subaro"},
        new Car(){ ModelYear = 2021 , Maker = "Toyota"},
        new Car(){ ModelYear = 2013 , Maker = "Subaro"},
        new Car(){ ModelYear = 2004 , Maker = "Fiat"},
        new Car(){ ModelYear = 2021 , Maker = "Fiat"},
        new Car(){ ModelYear = 2015 , Maker = "Subaro"}
};
//
Console.WriteLine("All cars in the agency:");
foreach (var car in a1)
    Console.WriteLine(car);
Console.WriteLine("All cars in the agency from 2021:");
foreach (var car in a1.GetCars(2021))
    Console.WriteLine(car);
Console.WriteLine("All cars in the agency of Fiat:");
foreach (var car in a1.GetCars("Fiat"))
    Console.WriteLine(car);
