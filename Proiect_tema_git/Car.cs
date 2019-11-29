using System;
namespace ConsoleApp1

{
public class Car : Vehicle
{
    public Car(string make, string model, string registration, string yearOfInitialRegistration, int currentValue)
    {
        Make = make;
        Model = model;
        Registration = registration;
        YearOfInitialRegistration = yearOfInitialRegistration;
        CurrentValue = currentValue;
    }

    // returns the car's current value as string
    public string GetCurrentValue()
    {
        return CurrentValue.ToString();
    }

    // returns the car's year of initial registration as string
    public string GetYearOfInitialRegistration()
    {
        return YearOfInitialRegistration;
    }

    public override string ToString()
    {
        return Make + " | " + Model + " | " + Registration + " | " + YearOfInitialRegistration + " | " + CurrentValue.ToString() + "\n";
    }

    // prints the car data to the console in a printer friendly format
    public void PrinterFriendly()
    {
        Console.WriteLine("\nCAR DATA");
        Console.WriteLine("------------");
        Console.WriteLine("Make: " + Make.ToString());
        Console.WriteLine("Model: " + Model.ToString());
        Console.WriteLine("Registration: " + Registration.ToString());
        Console.WriteLine("Year of initial registration: " + GetYearOfInitialRegistration());
        Console.WriteLine("Current value: " + GetCurrentValue());
        Console.WriteLine("------------\n");
    }
}
}