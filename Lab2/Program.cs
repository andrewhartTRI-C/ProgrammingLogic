namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1 | Operator Logic
        int a = 10;
        int b = 5;
        int c = 15;
        if (a > b)
        {
            Console.WriteLine(a + " is greater than " + b + "."); //If a is greater than b, print this statement
        }
        if (a < c)
        {
            Console.WriteLine(a + " is less than " + c + "."); //If a is less than c, print this statement
        }
        if (a > b && a > c)
        {
            Console.WriteLine(a + " is greater than " + b + " and " + c + "."); //If a is greater than both b and c, print this statement
        }
        if (a < b || a < c)
        {
            Console.WriteLine(a + " is less than either " + b + " or " + c + "."); //If a is less than either a or c, print this statement
        }
        //Part 2 | Boolean Logic
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!"); //If isRaining is true and haveUmbrella is false, print this statement
        }
        else
        {
            Console.WriteLine("You're good to go!"); //If isRaining is false or haveUmbrella is true, print this statement
        }
        //Part 3 | Conditional Logic
        Console.WriteLine("Enter your age:"); //Asks the user for their age
        int age = Convert.ToInt32(Console.ReadLine()); //Converts the integer value to a string and stores it as variable age
        if (age < 5)
        {
            Console.WriteLine("Ticket is free!"); //If the age input is less than 5, print this statement
        }
        else if (age > 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5"); //If the age input is greater than 5 and less than or equal to 12, print this statement
        }
        else if (age > 12 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10"); //If the age input is greater than 12 and less than or equal to 64, print this statement
        }
        else
        {
            Console.WriteLine("Senior ticket: $6"); //If the age input does not meet any previous criteria (age >= 65), print this statement
        }
        //Part 4 | Using a Switch Statement
        Console.WriteLine("Enter a day of the week (Sunday=1 to Saturday=7):"); //Asks the user to input a day of the week from 1-7
        int dayoftheWeek = Convert.ToInt32(Console.ReadLine()); //Converts the integer value to a string and stores it as variable dayoftheWeek
        switch(dayoftheWeek)
        {
            case 1:
                Console.WriteLine("Today is Sunday."); //If the input is 1, output Sunday
                break;
            case 2:
                Console.WriteLine("Today is Monday."); //If the input is 2, output Monday
                break;
            case 3:
                Console.WriteLine("Today is Tuesday."); //If the input is 3, output Tuesday
                break;
            case 4:
                Console.WriteLine("Today is Wednesday."); //If the input is 4, output Wednesday
                break;
            case 5:
                Console.WriteLine("Today is Thursday."); //If the input is 5, output Thursday
                break;
            case 6:
                Console.WriteLine("Today is Friday."); //If the input is 6, output Friday
                break;
            case 7:
                Console.WriteLine("Today is Saturday."); //If the input is 7, output Saturday
                break;
            default:
                Console.WriteLine("Invalid day!"); //If the input is less than 1 or greater than 7, output this line
                break;
        }
    }
}
