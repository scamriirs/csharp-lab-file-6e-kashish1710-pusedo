//
using System;

using System;

class Car
{
    public Car()
    {
        make = "Toyota";
        model = "Corolla";
        year = 2020;
    }

    public string make;
    public string model;
    public int year;

    public void DisplayCarDetails()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Car myCar = new Car();

      
        myCar.DisplayCarDetails();

        Console.ReadLine();
    }
}
