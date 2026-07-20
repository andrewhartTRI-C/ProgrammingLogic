namespace Lab4;

using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    // Problem 1: Add a Method with No Parameters
    public void Start() //Defines the Start method a public access modifier, as it will be called in the Program class
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Add a Method with Parameters
    public void Drive(int miles) // Defines the Drive method with the integer variable miles and with a public access modifier, as it will be called in the Program class
    {
        Console.WriteLine("The car drove " + miles + " miles."); 
    }

    //Problem 3: Add a Method with a Return Value
    public string GetDescription() // Defines the GetDescription method with a string return and a public access modifier, as it will be called in the Program class
    {
        return year + " " + color + " " + model;
    }

    //Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor) // Defines the Repaint method with the string variable newColor and with a public access modifier, as it will be called in the Program class
    {
        color = newColor; // Updates the string variable color to the string variable newColor
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }
}
class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        
        myCar.Start(); // Problem 1 continued; Calls the Start method
        
        myCar.Drive(50); // Problem 2 continued; Calls the Drive method and assigns the integer variable miles a value of 50
        
        string description = myCar.GetDescription(); // Problem 3 continued; Stores the output of the GetDescription method as the string variable description
        Console.WriteLine(description); // Problem 3 continued; Prints the output of the GetDescription method as the string variable description
        
        myCar.Repaint("red"); // Problem 4 continued; Calls the Repaint method and assigns the string variable newColor to red
        Console.WriteLine("The new color of the car is " + myCar.color + "."); // Problem 4 continued; Confirms the color of the car is updated to red
    }
}



