//Write a program to show the usage of this keyword
using System;

class Test 
{ 
    int num;

    // Constructor should be public
    public Test(int num)
    {
        this.num = num;
    }

    // Main method with correct signature
    public static void Main()
    {
        // Correct class name capitalization
        Test t = new Test(4);

        // Correct WriteLine method
        Console.WriteLine("Value is " + t.num);
    }
}
