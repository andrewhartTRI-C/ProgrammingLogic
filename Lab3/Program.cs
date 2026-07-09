namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
    
    //Problem 1 | Simple For Loop; Print Numbers 1-10
        Console.WriteLine("\nHere are the numbers 1 to 10:");
        for (int i = 1; i <= 10; i++) //Starting at 1, increment the variable by 1 for each loop where it is less than or equal to 10
        {
            Console.WriteLine(i); //Outputs the current value of i
        }

    //Problem 2 | Even Numbers 1-20
        Console.WriteLine("\nHere are all the even numbers from 1 to 20:");
        int j = 1; //Defines j
        while (j <= 20) //Repeats the loop as long as j is less than or equal to 20
        {
            if ((j % 2) == 0) //If j is divided by 2 and has no remainder, execute the code within the brackets
            {
                Console.WriteLine(j); //Outputs the current value of j
            }
            j++;
        }

    //Problem 3 | Print numbers from 5 to 1, counting backwards
        Console.WriteLine("\nCounting down from 5 to 1 looks like this:");
        for (int k = 5; k >= 1; k--) //Starting at 5, decrement the variable by 1 for each loop where it is greater than or equal to 5
        {
            Console.WriteLine(k); //Outputs the current value of k
        }

    //Problem 4 | Print all multiples of 10, starting at 10, ending at 1000
        Console.WriteLine("\nThese are all the multiples of 10, up to 1000:");
        int l = 1; //Defines l
        while (l <= 1000) //Repeats the loop as long as l is less than or equal to 1000
        {
            if ((l % 10) == 0) //If l is divided by 10 and has no remainder, execute the code within the brackets
            {
                Console.WriteLine(l); //Outputs the current value of l
            }
            l++;
        }

    //Problem 5 | Seasons of the Year
        Console.WriteLine("\nThese are the four seasons of the year:");
        string[] seasons = new string[4]; //Declares and initializes a string array using the variable seasons with four empty elements
        seasons[0] = "Spring"; //Element 1; Array value 0
        seasons[1] = "Summer"; //Element 2; Array value 1
        seasons[2] = "Fall"; //Element 3; Array value 2
        seasons[3] = "Winter"; //Element 4; Array value 3

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

    //Problem 6 | Days of the Week
        string[] days = new string[7] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}; //Declares and initializes a string array using the variable days with seven named elements
        Console.WriteLine("\nEnter the current day of the week (Sunday=1 to Saturday=7):"); //Asks the user to input the current day of the week from 1-7
        int dayoftheWeek = Convert.ToInt32(Console.ReadLine()); //Converts the integer value to a string and stores it as variable dayoftheWeek
        
        switch(dayoftheWeek)
        {
            case 1:
                Console.WriteLine("Today is " + days[0] + "."); //If the input is 1, output the first element of the array
                break;
            case 2:
                Console.WriteLine("Today is " + days[1] + "."); //If the input is 2, output the second element of the array
                break;
            case 3:
                Console.WriteLine("Today is " + days[2] + "."); //If the input is 3, output the third element of the array
                break;
            case 4:
                Console.WriteLine("Today is " + days[3] + "."); //If the input is 4, output the fourth element of the array
                break;    
            case 5:
                Console.WriteLine("Today is " + days[4] + "."); //If the input is 5, output the fifth element of the array
                break;
            case 6:
                Console.WriteLine("Today is " + days[5] + "."); //If the input is 6, output the sixth element of the array
                break;
            case 7:
                Console.WriteLine("Today is " + days[6] + "."); //If the input is 7, output the seventh element of the array
                break;
            default:
                Console.WriteLine("Invalid number!"); //If the input is not applicable, output this
                break;
        }

        //Problem 7 | Favorite Books and Authors
        Console.WriteLine("\nMy favorite books!"); //Not actually all my favorite books since I only have a few
        string[] books = new string[3] { "The Westing Game", "1984", "Fake Book" }; //Declares and initializes a string array using the variable books with three named elements
        string[] authors = new string [3] { "Ellen Raskin", "George Orwell", "Fake Author" }; //Declares and initializes a string array using the variable authors with three named elements
       
        for (int m = 0; m < books.Length; m++) //Starting at 0 (for index 0 of the array), increment the variable by 1 for each loop where it is less than the length of one of the arrays (since they are the same size, this can work for either)
        {
            Console.WriteLine(books[m] + " by " + authors[m]); //Output the current index of both the books and authors arrays as "Book by Author"
        }

        //Problem 8 | Temperature Tracker
        int[] temperature = new int[5] { 64, 78, 91, 72, 84 }; //Declares and initializes an integer array using the variable temperature with five named elements

        Array.Sort(temperature); //Sorts the integers in the temperature array from lowest to highest

        Console.WriteLine("\nThese are the temperatures sorted from lowest to highest:");
        foreach (int temp in temperature) { //Loops through each index value (temp) in the temperature array
            Console.Write(temp + " \n");
        }
        Console.WriteLine("The highest temperature is " + temperature[4] + " and the lowest temperature is " + temperature[0] + "."); //Since the integer array is sorted from lowest to highest, the lowest index value is the smallest number and the highest index value is the largest

        //Problem 9 | Reverse Countdown
        int[] countdown = new int[5] { 5, 4, 3, 2, 1 }; //Declares and initializes an integer array using the variable countdown with five named elements

        Array.Reverse(countdown); //Reverses the order of the array

        Console.WriteLine("\nThis countdown is reversed!");
        foreach (int count in countdown) {
            Console.Write(count + " \n");
        }
        }
}

