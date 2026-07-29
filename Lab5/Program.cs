namespace Lab5;

//Step 1 | Create a Base Class
class Animal // Base class
{
    public virtual void animalSound() // Using the virtual keyword allows for derived classes to override this method 
    {
        Console.WriteLine("The animal makes a sound"); 
    }
}

//Step 2 | Create Derived Classes
class Cat : Animal // Derived class, inheriting from the Animal class
{
   public override void animalSound() // Overrides the base class method by using the override keyword, using this method's contents instead
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal // Derived class, inheriting from the Animal class
{
    public override void animalSound() // Overrides the base class method by using the override keyword, using this method's contents instead
    {
        Console.WriteLine("The dog says: bow wow");
    }   
}

//Step 3 | Test in Main

class Program // Independent class in which to execute the program by creating objects and calling methods
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Creates an Animal object
        Animal myCat = new Cat(); // Creates a Cat object
        Animal myDog = new Dog(); // Creates a Dog object

        myAnimal.animalSound(); // Calls the method in myAnimal
        myCat.animalSound(); // Calls the method in myCat and does not inherit the base class method as it was overriden
        myDog.animalSound(); // Calls the method in myDog and does not inherit the base class method as it was overriden
    }
}