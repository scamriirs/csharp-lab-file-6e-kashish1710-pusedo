//write a program to show the usage of parametrized constructor 
using System;

class Car
{
    // Parameterized constructor
    public Car(string make, string model, int year)
    {
        // Initializing fields with the provided parameters
        this.make = make;
        this.model = model;
        this.year = year;
    }

    // Fields for the Car class
    public string make;
    public string model;
    public int year;

    // Method to display car details
    public void DisplayCarDetails()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the Car class using the parameterized constructor
        Car myCar = new Car("Ford", "Mustang", 2023);

        // Calling the method to display car details
        myCar.DisplayCarDetails();

        Console.ReadLine();
    }
}
