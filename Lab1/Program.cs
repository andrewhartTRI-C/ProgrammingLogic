namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        /* Step 1: Comments 
        Andrew Hart
        IT-1050 - Lab 1 */

        //Step 2: Output//
        Console.WriteLine("Andrew Hart"); //My name
        Console.WriteLine("IT-1050"); //The class I am taking

        //Step 3: Variables//
        int favNumber = 43; //My favorite number
        Console.WriteLine("My favorite number is " + favNumber + ".");
       
        string favProgrammingLanguage = "Python"; //My favorite programming language
        Console.WriteLine("My favorite programming language is " + favProgrammingLanguage + ".");
       
        double numberOfPreviousPrograms = 25; //The number of previous programs I have written
        Console.WriteLine("I have written " + numberOfPreviousPrograms + " programs before this class.");
        
        bool programmingExperience = true; //Indicates I have previous programming experience
        Console.WriteLine("It is " + programmingExperience + " that I have previous programming experience.");

        //Step 4: Constants//
        const string schoolName = "Cuyahoga Community College"; //Permanently stores the text string as Tri-C
        Console.WriteLine("I am actively attending " + schoolName + ".");

        //Step 5: Type Casting//
        double myDouble = 9.78; //Assigns the float value to myDouble
        int myInt = (int) myDouble; //Larger data type to smaller data type via explicit casting
        bool myBool = true; //Assigned true value to myBool

        Console.WriteLine("double: " + myDouble); //Displays the double value
        Console.WriteLine("integer: " + Convert.ToString(myInt)); //Converts the integer value to a string and displays it
        Console.WriteLine("boolean: " + Convert.ToString(myBool)); //Converts the boolean value to a string and displays it
    
        //Step 6: User Input and Type Conversion//
        Console.WriteLine("Enter your name:"); //Asks user for their username
        string Name = Console.ReadLine(); //Stores the user's input as a string
        Console.WriteLine("Enter your age:"); //Asks user for their age
        int Age = Convert.ToInt32(Console.ReadLine()); //Converts the user's input from an integer value to a string and stores it
        Console.WriteLine("Good day " + Name + ". You are currently " + Age + " years old."); //Formulates a response for the user using their inputs

        //Step 7: Arithmetic//
        Console.WriteLine("Input an integer:"); //Asks for a random integer
        int num1 = Convert.ToInt32(Console.ReadLine()); //Converts the integer value to a string
        Console.WriteLine("Input a second integer:"); //Asks for a second random integer
        int num2 = Convert.ToInt32(Console.ReadLine()); //Converts the integer value to a string
        int addition1 = num1 + 10; 
        int addition2 = num2 + 10;
        int subtraction1 = num1 - 2;
        int subtraction2 = num2 - 2;
        int multiplication1 = num1 * 3;
        int multiplication2 = num2 * 3;
        int division1 = num1 / 2;
        int division2 = num2 / 2;
        int modulus1 = num1 % 2;
        int modulus2 = num2 % 2;

        Console.WriteLine("Two values were given: " + num1 + " and " + num2 + ". Here are the following results of possible arithmetic: "); //Displays the integers provided by the user
        Console.WriteLine("Adding 10 to " + num1 + " equals " + addition1 + ", and adding 10 to " + num2 + " equals " + addition2 + "."); //Displays the addition performed
        Console.WriteLine("Subtracting 2 from " + num1 + " equals " + subtraction1 + ", and subtracting 2 from " + num2 + " equals " + subtraction2 + "."); //Displays the subtraction performed
        Console.WriteLine("Multiplying " + num1 + " by 3 equals " + multiplication1 + ", and multiplying " + num2 + " by 3 equals " + multiplication2 + "."); //Displays the multiplication performed
        Console.WriteLine("Dividing " + num1 + " by 2 equals " + division1 + ", and dividing " + num2 + " by 2 equals " + division2 + "."); //Displays the division performed (not including remainder)
        Console.WriteLine("Dividing " + num1 + " by 2 leaves a remainder of " + modulus1 + ", and dividing " + num2 + " by 2 leaves a remainder of " + modulus2 + "."); //Displays the remainder left after performing division

        //Step 8: Floating Point Precision//
        float precision1 = 1.123456789F; //Defined float value
        double precision2 = 1.123456789D; //Defined double value

        Console.WriteLine("The original float value input is 1.123456789; observe the difference between what a float value and a double value can store:");
        Console.WriteLine("Float: " + precision1); //Float values display up to six or seven decimal places, and the full value is not displayed
        Console.WriteLine("Double: " + precision2); //Double values display about fifteen decimal places, and the full value is displayed

        //Step 9: Increment and Decrement//
        int rValue = 10;
        Console.WriteLine("The starting integer is 10.");
        rValue++;
        Console.WriteLine("Incrementing the integer equals " + rValue + "."); //Increments rValue by 1, equaling 11
        rValue--;
        Console.WriteLine("Decrementing the integer equals " + rValue + "."); //Decrements rValue by 1, equaling 10
        rValue--;
        Console.WriteLine("Decrementing the integer again equals " + rValue + "."); //Decrements rValue by 1, equaling 9
    }
}

